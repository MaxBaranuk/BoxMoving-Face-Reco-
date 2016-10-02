using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof (Text))]
    public class FPSCounter : MonoBehaviour
    {
        const float fpsMeasurePeriod = 0.5f;
        private int m_FpsAccumulator = 0;
        private float m_FpsNextPeriod = 0;
        private int m_CurrentFps;
        const string display = "{0} / {1} FPS";
        private Text m_Text;
        Queue<int> fpss = new Queue<int>();

        private void Start()
        {
            m_FpsNextPeriod = Time.realtimeSinceStartup + fpsMeasurePeriod;
            m_Text = GetComponent<Text>();
        }


        private void Update()
        {
            if (fpss.Count > 200) fpss.Dequeue();
            // measure average frames per second
            m_FpsAccumulator++;
            if (Time.realtimeSinceStartup > m_FpsNextPeriod)
            {
                m_CurrentFps = (int) (m_FpsAccumulator/fpsMeasurePeriod);
                fpss.Enqueue(m_CurrentFps);
                m_FpsAccumulator = 0;
                m_FpsNextPeriod += fpsMeasurePeriod;

                IEnumerator<int> iter = fpss.GetEnumerator();
                int summ = 0;
                while (iter.MoveNext()) {
                    summ += iter.Current;
                }
                int middle = summ / fpss.Count;
                m_Text.text = string.Format(display, m_CurrentFps, middle);
            }
        }
    }
}
