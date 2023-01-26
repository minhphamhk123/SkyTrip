using System;
using BeyondLine.Apod.MarsRoverPhotos;

namespace BeyondLine.Apod
{
    /// <summary>
    /// Class for interacting with other nasa api services from a
    /// single location
    /// </summary>
    public class NasaApiService : INasaApiService
    {
        public NasaApiService(
            IRoverPhotoService roverPhotoService)
        {
            MarsRoverPhotos = roverPhotoService;
        }

        /// <summary>
        /// Interact with the Mars Rover Photos service with an injected
        /// instance of its interface
        /// </summary>
        public IRoverPhotoService MarsRoverPhotos { get; set; }
    }
}