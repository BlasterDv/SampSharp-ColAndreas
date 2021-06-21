using SampSharp.GameMode;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.ColAndreas.Data
{
    public class RayCastLine
    {
        public RayCastLine(Vector3 position)
        {
            Position = position;
        }
     
        public RayCastLine(Vector3 position, int modelId) : this(position)
        {
            ModelId = modelId;
        }

        public int ModelId { get; }

        public Vector3 Position { get; }

        public static RayCastLine NoCollision = new RayCastLine(Vector3.Zero);
    }
}
