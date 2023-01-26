using BeyondLine.Apod.MarsRoverPhotos;

namespace BeyondLine.Services
{
    /// <summary>
    /// Interface for a service interacting with some of Nasa's Open APIs.
    /// </summary>
    public interface INasaApiService
    {
        /// <summary>
        /// Property to interact with the Mars Rover 
        /// Photos service.
        /// </summary>
        IRoverPhotoService MarsRoverPhotos { get; set; } }
}