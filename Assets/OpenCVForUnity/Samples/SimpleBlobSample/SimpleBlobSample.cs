﻿using UnityEngine;
using System.Collections.Generic;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
using OpenCVForUnity;

namespace OpenCVForUnitySample
{
		/// <summary>
		/// Simple BLOB sample.
		/// </summary>
		public class SimpleBlobSample : MonoBehaviour
		{
		
				// Use this for initialization
				void Start ()
				{
			
						Texture2D imgTexture = Resources.Load ("detect_blob") as Texture2D;
			
						Mat imgMat = new Mat (imgTexture.height, imgTexture.width, CvType.CV_8UC1);

						Utils.texture2DToMat (imgTexture, imgMat);
						Debug.Log ("imgMat dst ToString " + imgMat.ToString ());
						
						Mat outImgMat = new Mat ();

						FeatureDetector blobDetector = FeatureDetector.create (FeatureDetector.SIMPLEBLOB);

						blobDetector.read (Utils.getFilePath ("blobparams.yml"));


						MatOfKeyPoint keypoints = new MatOfKeyPoint ();
						blobDetector.detect (imgMat, keypoints);
						Features2d.drawKeypoints (imgMat, keypoints, outImgMat);

			
						Texture2D texture = new Texture2D (outImgMat.cols (), outImgMat.rows (), TextureFormat.RGBA32, false);
			
						Utils.matToTexture2D (outImgMat, texture);
			
						gameObject.GetComponent<Renderer> ().material.mainTexture = texture;
			
				}
		
				// Update is called once per frame
				void Update ()
				{
			
				}
		
				public void OnBackButton ()
				{
						#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("OpenCVForUnitySample");
						#else
						Application.LoadLevel ("OpenCVForUnitySample");
						#endif
				}
		}
}