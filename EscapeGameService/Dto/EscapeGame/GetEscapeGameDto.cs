﻿using EscapeGameService.Dto.Base;
using EscapeGameService.Dto.DifficultyLevel;
using EscapeGameService.Dto.Price;

namespace EscapeGameService.Dto.EscapeGame
{
    public class GetEscapeGameDto : BaseDto
    {
        public int ESGId { get; set; }
        public string ESGNom { get; set; } = string.Empty;
        public string ESGCreator { get; set; } = string.Empty;
        public string ESGTitle { get; set; } = string.Empty;
        public string ESGContent { get; set; } = string.Empty;
        public string ESGImgResources { get; set; } = string.Empty;
        public string ESGWebsite { get; set; } = string.Empty;
        public string ESGPhoneNumber { get; set; } = string.Empty;
        public bool ESG_IsDeleting { get; set; }
        public bool ESG_IsForChildren { get; set; }
        public int ESG_Price_Id { get; set; }
        public int ESG_DILE_Id { get; set; }
        public GetPriceDto? Price { get; set; }
        public GetDifficultyLevelDto? DifficultyLevel { get; set; }
        public DateTime ESG_CreationDate { get; set; }
        public DateTime ESG_UpdateTime { get; set; }
    }
}
