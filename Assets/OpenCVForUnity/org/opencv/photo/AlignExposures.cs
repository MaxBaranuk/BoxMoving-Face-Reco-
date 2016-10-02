﻿
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class AlignExposures
//javadoc: AlignExposures
		public class AlignExposures : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_AlignExposures_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				protected AlignExposures (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  void process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
				//

				//javadoc: AlignExposures::process(src, dst, times, response)
				public virtual void process (List<Mat> src, List<Mat> dst, Mat times, Mat response)
				{
						ThrowIfDisposed ();
						if (times != null)
								times.ThrowIfDisposed ();
						if (response != null)
								response.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
        photo_AlignExposures_process_10(nativeObj, src_mat.nativeObj, dst_mat.nativeObj, times.nativeObj, response.nativeObj);
        
        return;
#else
						return;
#endif
				}


    
		#if UNITY_IOS && !UNITY_EDITOR
		const string LIBNAME = "__Internal";
		#else
				const string LIBNAME = "opencvforunity";
		#endif


				// C++:  void process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
				[DllImport(LIBNAME)]
				private static extern void photo_AlignExposures_process_10 (IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void photo_AlignExposures_delete (IntPtr nativeObj);

		}
}
