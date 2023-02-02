using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaApiExplorer.Models
{
    public class NASAEarthPolychromaticImagingCamera
    {
        public struct NASA_EPIC_DATE_STRUCTURE
        {
            [JsonProperty("date")]
            public DateTime? Date { get; set; }
        }

        public struct NASA_EPIC_QUATERNIONS
        {
            [JsonProperty("q0")]
            public double Q0 { get; set; }

            [JsonProperty("q1")]
            public double Q1 { get; set; }

            [JsonProperty("q2")]
            public double Q2 { get; set; }

            [JsonProperty("q3")]
            public double Q3 { get; set; }
        }

        public struct NASA_EPIC_3D_POINT
        {
            [JsonProperty("x")]
            public double X { get; set; }

            [JsonProperty("y")]
            public double Y { get; set; }

            [JsonProperty("z")]
            public double Z { get; set; }
        }

        public struct NASA_EPIC_COORDINATES
        {
            [JsonProperty("centroid_coordinates")]
            public NASA_EPIC_3D_POINT? CentroIdCoordinates { get; set; }

            [JsonProperty("dscovr_j2000_position")]
            public NASA_EPIC_3D_POINT? Dscovr_J2000_Position { get; set; }

            [JsonProperty("lunar_j2000_position")]
            public NASA_EPIC_3D_POINT? Lunar_J2000_Position { get; set; }

            [JsonProperty("sun_j2000_position")]
            public NASA_EPIC_3D_POINT? Sun_J2000_Position { get; set; }

            [JsonProperty("attitude_quaternions")]
            public NASA_EPIC_QUATERNIONS? AttitudeQuaternions { get; set; }
        }

        public struct NASA_EPIC_GEOGRAPHICAL_COORDINATES
        {
            [JsonProperty("lat")]
            public double Latitude { get; set; }

            [JsonProperty("lon")]
            public double Longitude { get; set; }
        }

        public struct NASA_EPIC_DATA
        {
            [JsonProperty("identifier")]
            public string Identifier { get; set; }

            [JsonProperty("caption")]
            public string Caption { get; set; }

            [JsonProperty("image")]
            public string Image { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("centroid_coordinates")]
            public NASA_EPIC_GEOGRAPHICAL_COORDINATES CentroIdCoordinates { get; set; }

            [JsonProperty("dscovr_j2000_position")]
            public NASA_EPIC_3D_POINT Dscovr_J2000_Position { get; set; }

            [JsonProperty("lunar_j2000_position")]
            public NASA_EPIC_3D_POINT Lunar_J2000_Position { get; set; }

            [JsonProperty("sun_j2000_position")]
            public NASA_EPIC_3D_POINT Sun_J2000_Position { get; set; }

            [JsonProperty("attitude_quaternions")]
            public NASA_EPIC_QUATERNIONS AttitudeQuaternions { get; set; }

            [JsonProperty("date")]
            public DateTime Date { get; set; }

            [JsonProperty("coords")]
            public NASA_EPIC_COORDINATES Coordinates { get; set; }
        }
    }
}
