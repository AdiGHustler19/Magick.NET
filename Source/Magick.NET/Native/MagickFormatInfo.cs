//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
// <auto-generated/>

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
  public partial class MagickFormatInfo
  {
    private static class NativeMethods
    {
      #if PLATFORM_x64 || PLATFORM_AnyCPU
      public static class X64
      {
        #if PLATFORM_AnyCPU
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickFormatInfo+NativeMethods.X64#.cctor()")]
        static X64() { NativeLibraryLoader.Load(); }
        #endif
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_Description_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_CanReadMultithreaded_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_CanWriteMultithreaded_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_Format_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_IsMultiFrame_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_IsReadable_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_IsWritable_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_MimeType_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_Module_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_CreateList(out UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickFormatInfo_DisposeList(IntPtr instance, UIntPtr length);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_GetInfo(IntPtr list, UIntPtr index, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_GetInfoByName(IntPtr name, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_Unregister(IntPtr name);
      }
      #endif
      #if PLATFORM_x86 || PLATFORM_AnyCPU
      public static class X86
      {
        #if PLATFORM_AnyCPU
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickFormatInfo+NativeMethods.X86#.cctor()")]
        static X86() { NativeLibraryLoader.Load(); }
        #endif
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_Description_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_CanReadMultithreaded_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_CanWriteMultithreaded_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_Format_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_IsMultiFrame_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_IsReadable_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_IsWritable_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_MimeType_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_Module_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_CreateList(out UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickFormatInfo_DisposeList(IntPtr instance, UIntPtr length);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_GetInfo(IntPtr list, UIntPtr index, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickFormatInfo_GetInfoByName(IntPtr name, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickFormatInfo_Unregister(IntPtr name);
      }
      #endif
    }
    private sealed class NativeMagickFormatInfo : ConstNativeInstance
    {
      protected override string TypeName
      {
        get
        {
          return nameof(MagickFormatInfo);
        }
      }
      public string Description
      {
        get
        {
          IntPtr result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_Description_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_Description_Get(Instance);
          #endif
          return UTF8Marshaler.NativeToManaged(result);
        }
      }
      public bool CanReadMultithreaded
      {
        get
        {
          bool result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_CanReadMultithreaded_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_CanReadMultithreaded_Get(Instance);
          #endif
          return result;
        }
      }
      public bool CanWriteMultithreaded
      {
        get
        {
          bool result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_CanWriteMultithreaded_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_CanWriteMultithreaded_Get(Instance);
          #endif
          return result;
        }
      }
      public string Format
      {
        get
        {
          IntPtr result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_Format_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_Format_Get(Instance);
          #endif
          return UTF8Marshaler.NativeToManaged(result);
        }
      }
      public bool IsMultiFrame
      {
        get
        {
          bool result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_IsMultiFrame_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_IsMultiFrame_Get(Instance);
          #endif
          return result;
        }
      }
      public bool IsReadable
      {
        get
        {
          bool result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_IsReadable_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_IsReadable_Get(Instance);
          #endif
          return result;
        }
      }
      public bool IsWritable
      {
        get
        {
          bool result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_IsWritable_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_IsWritable_Get(Instance);
          #endif
          return result;
        }
      }
      public string MimeType
      {
        get
        {
          IntPtr result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_MimeType_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_MimeType_Get(Instance);
          #endif
          return UTF8Marshaler.NativeToManaged(result);
        }
      }
      public string Module
      {
        get
        {
          IntPtr result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_Module_Get(Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_Module_Get(Instance);
          #endif
          return UTF8Marshaler.NativeToManaged(result);
        }
      }
      public IntPtr CreateList(out UIntPtr length)
      {
        IntPtr exception = IntPtr.Zero;
        IntPtr result;
        #if PLATFORM_AnyCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if PLATFORM_x64 || PLATFORM_AnyCPU
        result = NativeMethods.X64.MagickFormatInfo_CreateList(out length, out exception);
        #endif
        #if PLATFORM_AnyCPU
        else
        #endif
        #if PLATFORM_x86 || PLATFORM_AnyCPU
        result = NativeMethods.X86.MagickFormatInfo_CreateList(out length, out exception);
        #endif
        MagickException magickException = MagickExceptionHelper.Create(exception);
        if (MagickExceptionHelper.IsError(magickException))
        {
          if (result != IntPtr.Zero)
            DisposeList(result, (int)length);
          throw magickException;
        }
        RaiseWarning(magickException);
        return result;
      }
      public static void DisposeList(IntPtr instance, int length)
      {
        #if PLATFORM_AnyCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if PLATFORM_x64 || PLATFORM_AnyCPU
        NativeMethods.X64.MagickFormatInfo_DisposeList(instance, (UIntPtr)length);
        #endif
        #if PLATFORM_AnyCPU
        else
        #endif
        #if PLATFORM_x86 || PLATFORM_AnyCPU
        NativeMethods.X86.MagickFormatInfo_DisposeList(instance, (UIntPtr)length);
        #endif
      }
      public void GetInfo(IntPtr list, int index)
      {
        IntPtr exception = IntPtr.Zero;
        IntPtr result;
        #if PLATFORM_AnyCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if PLATFORM_x64 || PLATFORM_AnyCPU
        result = NativeMethods.X64.MagickFormatInfo_GetInfo(list, (UIntPtr)index, out exception);
        #endif
        #if PLATFORM_AnyCPU
        else
        #endif
        #if PLATFORM_x86 || PLATFORM_AnyCPU
        result = NativeMethods.X86.MagickFormatInfo_GetInfo(list, (UIntPtr)index, out exception);
        #endif
        CheckException(exception);
        Instance = result;
      }
      public void GetInfoByName(string name)
      {
        using (INativeInstance nameNative = UTF8Marshaler.CreateInstance(name))
        {
          IntPtr exception = IntPtr.Zero;
          IntPtr result;
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          result = NativeMethods.X64.MagickFormatInfo_GetInfoByName(nameNative.Instance, out exception);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          result = NativeMethods.X86.MagickFormatInfo_GetInfoByName(nameNative.Instance, out exception);
          #endif
          CheckException(exception);
          Instance = result;
        }
      }
      public static bool Unregister(string name)
      {
        using (INativeInstance nameNative = UTF8Marshaler.CreateInstance(name))
        {
          #if PLATFORM_AnyCPU
          if (NativeLibrary.Is64Bit)
          #endif
          #if PLATFORM_x64 || PLATFORM_AnyCPU
          return NativeMethods.X64.MagickFormatInfo_Unregister(nameNative.Instance);
          #endif
          #if PLATFORM_AnyCPU
          else
          #endif
          #if PLATFORM_x86 || PLATFORM_AnyCPU
          return NativeMethods.X86.MagickFormatInfo_Unregister(nameNative.Instance);
          #endif
        }
      }
    }
  }
}
