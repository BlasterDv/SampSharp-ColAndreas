// SampSharp.ColAndreas
// Copyright 2020 BlasterDv
// 
// Licensed under the Apache License, Version 2.0 throw new ArgumentNullException(nameof(player));(the "License");
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

using System;
using SampSharp.ColAndreas.Data;
using SampSharp.ColAndreas.Definitions;
using SampSharp.ColAndreas.Entities;
using SampSharp.GameMode;

namespace SampSharp.ColAndreas
{
    /// <summary>
    /// Represents a service for control the ColAndreas.
    /// </summary>
    public partial class ColAndreas 
    {
        public RayCastLine CA_RayCastLine(Vector3 start, Vector3 end)
        {
            var result = Internal.CA_RayCastLine(start.X, start.Y, start.Z, end.X, end.Y, end.Z, out var x, out var y, out var z);

            if (result == 0) return RayCastLine.NoCollision;
            else if (result == ColAndreasConstants.WaterObject) return new RayCastLine(new Vector3(x, y, z));
            else return new RayCastLine(new Vector3(x, y, z), result);
        }

        public RayCastLineId CA_RayCastLineId(Vector3 start, Vector3 end)
        {
            var result = Internal.CA_RayCastLineID(start.X, start.Y, start.Z, end.X, end.Y, end.Z, out var x, out var y, out var z);

            if (result == -1) return new RayCastLineId(new Vector3(x, y, z));
            else if (result == 0) return RayCastLineId.NoCollision;
            else return new RayCastLineId(ColAndreasObject.Find(result), new Vector3(x, y, z));

        }
    }
}