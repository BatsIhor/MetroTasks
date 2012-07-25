using System;
using System.Collections.Generic;

namespace MetroTasks.Models
{
    /// <summary>
    /// The MetroTasks Model interface.
    /// </summary>
    public interface IMetroTasksModel
    {
        /// <summary>
        /// Gets the ablums.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetAlbums();

        /// <summary>
        /// Gets the artists.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetArtists();

        /// <summary>
        /// Gets the tracks.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetTracks();
    }
}
