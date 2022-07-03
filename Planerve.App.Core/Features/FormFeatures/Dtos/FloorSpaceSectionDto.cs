using System.Collections.Generic;

namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class FloorSpaceSectionDto
    {
        public bool DoesIncludeGainOrLoss { get; set; }
        public ICollection<FloorSpaceDto> FloorSpaces { get; set; }
        public ICollection<RoomInformationDto> RoomInformation { get; set; }
    }

    public class FloorSpaceDto
    {
        public string Type { get; set; }
        public int ExistingGrossFloorspace { get; set; }
        public int GrossFloorspaceToBeLost { get; set; }
        public int TotalGrossFloorspaceProposed { get; set; }
        public int NetAdditionalGrossFloorspace { get; set; }
    }

    public class RoomInformationDto
    {
        public string Type { get; set; }
        public int ExistingRoomsToBeLost { get; set; }
        public int TotalRoomsProposed { get; set; }
        public int NetAdditionalRooms { get; set; }
    }
}
