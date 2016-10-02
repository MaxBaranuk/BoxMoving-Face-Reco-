﻿
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class AdaptiveManifoldFilter
//javadoc: AdaptiveManifoldFilter
		public class AdaptiveManifoldFilter : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_AdaptiveManifoldFilter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public AdaptiveManifoldFilter (IntPtr addr) : base(addr)
				{
				}


				//
				// C++: static Ptr_AdaptiveManifoldFilter create()
				//

				//javadoc: AdaptiveManifoldFilter::create()
				public static AdaptiveManifoldFilter create ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        AdaptiveManifoldFilter retVal = new AdaptiveManifoldFilter(ximgproc_AdaptiveManifoldFilter_create_10());
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  void collectGarbage()
				//

				//javadoc: AdaptiveManifoldFilter::collectGarbage()
				public  void collectGarbage ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ximgproc_AdaptiveManifoldFilter_collectGarbage_10(nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void filter(Mat src, Mat& dst, Mat joint = Mat())
				//

				//javadoc: AdaptiveManifoldFilter::filter(src, dst, joint)
				public  void filter (Mat src, Mat dst, Mat joint)
				{
						ThrowIfDisposed ();
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (joint != null)
								joint.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ximgproc_AdaptiveManifoldFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj, joint.nativeObj);
        
        return;
#else
						return;
#endif
				}

				//javadoc: AdaptiveManifoldFilter::filter(src, dst)
				public  void filter (Mat src, Mat dst)
				{
						ThrowIfDisposed ();
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ximgproc_AdaptiveManifoldFilter_filter_11(nativeObj, src.nativeObj, dst.nativeObj);
        
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


				// C++: static Ptr_AdaptiveManifoldFilter create()
				[DllImport(LIBNAME)]
				private static extern IntPtr ximgproc_AdaptiveManifoldFilter_create_10 ();

				// C++:  void collectGarbage()
				[DllImport(LIBNAME)]
				private static extern void ximgproc_AdaptiveManifoldFilter_collectGarbage_10 (IntPtr nativeObj);

				// C++:  void filter(Mat src, Mat& dst, Mat joint = Mat())
				[DllImport(LIBNAME)]
				private static extern void ximgproc_AdaptiveManifoldFilter_filter_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr joint_nativeObj);

				[DllImport(LIBNAME)]
				private static extern void ximgproc_AdaptiveManifoldFilter_filter_11 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void ximgproc_AdaptiveManifoldFilter_delete (IntPtr nativeObj);

		}
}
