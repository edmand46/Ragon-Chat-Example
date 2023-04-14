using Ragon.Protocol;
using UnityEngine;

namespace Ragon.Client.Unity.Payload
{
  // public class RagonCreatePayload: IRagonPayload
  // {
  //   public Vector3 Position;
  //   public Vector3 Rotation;
  //   public IRagonPayload Payload;
  //
  //   public void Serialize(RagonBuffer buffer)
  //   {
  //     buffer.WriteFloat(Position.x, -1024, 1024, 0.1f);
  //     buffer.WriteFloat(Position.y, -1024, 1024, 0.1f);
  //     buffer.WriteFloat(Position.z, -1024, 1024, 0.1f);
  //     
  //     buffer.WriteFloat(Position.x, -1024, 1024, 0.1f);
  //     buffer.WriteFloat(Position.y, -1024, 1024, 0.1f);
  //     buffer.WriteFloat(Position.z, -1024, 1024, 0.1f);
  //     
  //     Payload?.Serialize(buffer);
  //   }
  //
  //   public void Deserialize(RagonBuffer buffer)
  //   {
  //     Position.x = buffer.ReadFloat(-1024, 1024, 0.1f);
  //     Position.y = buffer.ReadFloat(-1024, 1024, 0.1f);
  //     Position.z = buffer.ReadFloat(-1024, 1024, 0.1f);
  //     
  //     Rotation.x = buffer.ReadFloat(-1024, 1024, 0.1f);
  //     Rotation.y = buffer.ReadFloat(-1024, 1024, 0.1f);
  //     Rotation.z = buffer.ReadFloat(-1024, 1024, 0.1f);
  //     
  //     Payload?.Deserialize(buffer);
  //   }
  // }
}