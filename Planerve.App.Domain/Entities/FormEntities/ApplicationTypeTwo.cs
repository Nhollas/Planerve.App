using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.FormEntities
{
    public class ApplicationTypeTwo
    {
        [ForeignKey("Application")]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Application Application { get; set; }

        #region Section 1

        public string OneTextOne { get; set; }
        public string OneTextTwo { get; set; }
        public string OneTextThree { get; set; }
        public string OneTextFour { get; set; }
        public string OneTextFive { get; set; }
        public string OneTextSix { get; set; }
        public string OneTextSeven { get; set; }
        public string OneTextEight { get; set; }
        public string OneTextNine { get; set; }
        public string OneTextTen { get; set; }
        public string OneTextEleven { get; set; }
        public string OneTextTwelve { get; set; }
        public string OneTextThirteen { get; set; }
        public string OneTextFourteen { get; set; }
        public string OneTextFithteen { get; set; }

        #endregion

        #region Section 2

        public string TwoTextOne { get; set; }
        public string TwoTextTwo { get; set; }
        public string TwoTextThree { get; set; }
        public string TwoTextFour { get; set; }
        public string TwoTextFive { get; set; }
        public string TwoTextSix { get; set; }
        public string TwoTextSeven { get; set; }
        public string TwoTextEight { get; set; }
        public string TwoTextNine { get; set; }
        public string TwoTextTen { get; set; }
        public string TwoTextEleven { get; set; }
        public string TwoTextTwelve { get; set; }
        public string TwoTextThirteen { get; set; }
        public string TwoTextFourteen { get; set; }
        public string TwoTextFithteen { get; set; }

        #endregion
    }
}
