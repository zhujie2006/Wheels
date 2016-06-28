using System.Windows.Media;

namespace Wheels.Models
{
    /// <summary>
    /// Model of Icon data
    /// </summary>
    public class IconModel
    {
        /// <summary>
        /// Resource key
        /// </summary>
        public string IconKey { get; set; }

        /// <summary>
        /// Path Data
        /// </summary>
        public Geometry IconData { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Resource key</param>
        /// <param name="data">Path Data</param>
        public IconModel(string key, Geometry data)
        {
            IconKey = key;
            IconData = data;
        }

    }
}