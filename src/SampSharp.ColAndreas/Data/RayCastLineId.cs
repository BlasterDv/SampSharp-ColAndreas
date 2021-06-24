using SampSharp.ColAndreas.Entities;
using SampSharp.GameMode;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.ColAndreas.Data
{
    public class RayCastLineId
    {
        public RayCastLineId(Vector3 position)
        {
            Position = position;
        }
     
        public RayCastLineId(ColAndreasObject colAndreasObject, Vector3 position) : this(position)
        {
            ColAndreasObject = colAndreasObject;
        }

        public ColAndreasObject ColAndreasObject { get; }

        public Vector3 Position { get; }

        public static RayCastLineId NoCollision { get; } = new RayCastLineId(Vector3.Zero);
    }
}
