// SampSharp.ColAndreas
// Copyright 2020 BlasterDv
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SampSharp.Core.Natives.NativeObjects;
using System;

namespace SampSharp.ColAndreas
{
    public partial class ColAndreas
    {
        public static ColAndreasInternal Internal { get; }

        static ColAndreas()
        {
            Internal = NativeObjectProxyFactory.CreateInstance<ColAndreasInternal>();
        }

        public class ColAndreasInternal
        {
            [NativeMethod]
            public virtual int CA_RayCastLine(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_RayCastLineID( float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_RayCastLineExtraID(int type, float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_RayCastLineAngle(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float rx, out float ry, out float rz)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_RayCastReflectionVector(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float nx, out float ny, out float nz)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_RayCastLineNormal(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float nx, out float ny, out float nz)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_ContactTest(int modelid, float x, float y, float z, float rx, float ry, float rz)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_SetObjectExtraID(int index, int type, int data)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_GetObjectExtraID(int index, int type)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_CreateObject(int modelid, float x, float y, float z, float rx, float ry, float rz, bool add)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_DestroyObject(int index)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_IsValidObject(int index)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual int CA_SetObjectPos(int index, float x, float y, float z)
            {
                throw new NotImplementedException();
            }

            [NativeMethod]
            public virtual void CA_SetObjectRot(int index, float rx, float ry, float rz)
            {
                throw new NotImplementedException();
            }
        }
    }
}