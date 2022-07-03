using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class FloorSpaceSection
    {
        public Guid Id { get; set; }
        public bool DoesIncludeGainOrLoss { get; set; }
        public ICollection<FloorSpace> FloorSpaces { get; set; }
        public ICollection<RoomInformation> RoomInformations { get; set; }
    }

    public class FloorSpace
    {
        public string Type { get; set; }
        public int ExistingGrossFloorspace { get; set; }
        public int GrossFloorspaceToBeLost { get; set; }
        public int TotalGrossFloorspaceProposed { get; set; }
        public int NetAdditionalGrossFloorspace { get; set; }
    }

    public class RoomInformation
    {
        public string Type { get; set; }
        public int ExistingRoomsToBeLost { get; set; }
        public int TotalRoomsProposed { get; set; }
        public int NetAdditionalRooms { get; set; }
    }
}
