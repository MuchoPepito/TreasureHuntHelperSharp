﻿namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.Party
{
    using Enums;
    using Utils.IO;

    public class DungeonPartyFinderPlayer : NetworkType
    {
        public const ushort ProtocolId = 373;
        public override ushort TypeID => ProtocolId;
        public ulong PlayerId { get; set; }
        public string PlayerName { get; set; }
        public sbyte Breed { get; set; }
        public bool Sex { get; set; }
        public ushort Level { get; set; }

        public DungeonPartyFinderPlayer(ulong playerId, string playerName, sbyte breed, bool sex, ushort level)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            Breed = breed;
            Sex = sex;
            Level = level;
        }

        public DungeonPartyFinderPlayer() { }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhLong(PlayerId);
            writer.WriteUTF(PlayerName);
            writer.WriteSByte(Breed);
            writer.WriteBoolean(Sex);
            writer.WriteVarUhShort(Level);
        }

        public override void Deserialize(IDataReader reader)
        {
            PlayerId = reader.ReadVarUhLong();
            PlayerName = reader.ReadUTF();
            Breed = reader.ReadSByte();
            Sex = reader.ReadBoolean();
            Level = reader.ReadVarUhShort();
        }

    }
}
