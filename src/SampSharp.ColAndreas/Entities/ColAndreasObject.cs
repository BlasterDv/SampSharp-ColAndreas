using SampSharp.ColAndreas.Definitions;
using SampSharp.GameMode;
using SampSharp.GameMode.Pools;

namespace SampSharp.ColAndreas.Entities
{
    public class ColAndreasObject : IdentifiedPool<ColAndreasObject>
    {
        private Vector3 _position;
        private Vector3 _rotation;

        public ColAndreasObject(int modelId, Vector3 position, Vector3 rotation, bool add)
        {
            Id = ColAndreas.Internal.CA_CreateObject(modelId, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, add);
            _position = position;
            _rotation = rotation;
        }
        
        public int IsValid 
        { 
            get => ColAndreas.Internal.CA_IsValidObject(Id);
        }

        public Vector3 Position
        {
            get => _position;
            set
            {
                ColAndreas.Internal.CA_SetObjectPos(Id, value.X, value.Y, value.Z);
                _position = value;
            }
        }

        public Vector3 Rotation
        {
            get => _rotation;
            set
            {
                ColAndreas.Internal.CA_SetObjectRot(Id, value.X, value.Y, value.Z);
                _rotation = value;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (IsDisposed) return;

            ColAndreas.Internal.CA_DestroyObject(Id);

            base.Dispose(disposing);
        }
        
        public void SetExtra(ExtraId type, int data)
        {
            ColAndreas.Internal.CA_SetObjectExtraID(Id, (int)type, data);
        }

        public int GetExtra(ExtraId type)
        {
            return ColAndreas.Internal.CA_GetObjectExtraID(Id, (int)type);
        }
    }
}
