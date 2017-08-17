using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageThis.com.microsoft.msdn.services;
using System.IO;
using System.Web;
using System.Xml.Serialization;
using PackageThis.Properties;

namespace ContentServiceLibrary {
    public class MyCacheImpl {
        private static string cacheDir {
            get {
                if (String.IsNullOrEmpty(Settings.Default.CacheDir)) {
                    throw new ApplicationException("CacheDir is not set!");
                }
                return Settings.Default.CacheDir;
            }
        }

        public static getContentResponse GetContentOr(getContentRequest key, Func<getContentResponse> loader) {
            var fi = new FileInfo(filePathOf(key));
            if (fi.Exists) {
                using (var fs = fi.OpenRead()) {
                    return (getContentResponse)new XmlSerializer(typeof(getContentResponse)).Deserialize(fs);
                }
            }
            else {
                var data = loader();
                fi.Directory.Create();
                using (var fs = fi.Create()) {
                    new XmlSerializer(typeof(getContentResponse)).Serialize(fs, data);
                }
                return data;
            }
        }

        private static string filePathOf(getContentRequest request) {
            return Path.Combine(
                cacheDir,
                HttpUtility.UrlEncode(request.version),
                HttpUtility.UrlEncode(request.locale),
                HttpUtility.UrlEncode(request.contentIdentifier)
                );
        }
    }
}
