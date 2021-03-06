/// Added the includedPaths and includedMimetyps, and the cache settings and path settings.

using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
using System.Xml;

namespace Powerasp.Enterprise.Core.Web.WebModule
{
    public class HttpCompressionModuleConfigurationSection : ConfigurationSection
    {
        /// <summary>
        /// Gets or sets the type of the compression.
        /// </summary>
        /// <value>The type of the compression.</value>
        [ConfigurationProperty("compressionType", IsRequired = false)]
        public CompressionType CompressionType
        {
            get
            {
                { return (base["compressionType"] == null) ? CompressionType.None : (CompressionType)base["compressionType"]; }
            }
            set
            {
                { base["compressionType"] = value; }
            }
        }

        /// <summary>
        /// Gets the cache settings for javascript and css.
        /// </summary>
        /// <value>The cache settings.</value>
        [ConfigurationProperty("CacheSettings", IsDefaultCollection = false)]
        public Cache CacheSettings
        {
            get
            {
                return (Cache)base["CacheSettings"]; 
            }
        }

        /// <summary>
        /// Gets the directories for javascript or css.
        /// </summary>
        /// <value>The Paths.</value>
        [ConfigurationProperty("PathSettings", IsDefaultCollection = false)]
        public Paths PathSettings
        {
            get
            {
                return (Paths)base["PathSettings"];
            }
        }

        /// <summary>
        /// Gets the excluded paths.
        /// </summary>
        /// <value>The paths.</value>
        [ConfigurationProperty("ExcludedPaths", IsDefaultCollection = false)]
        public ExcludedPaths ExcludedPaths
        {
            get
            {
                return (ExcludedPaths)base["ExcludedPaths"];
            }
        }

        /// <summary>
        /// Gets the excluded MIME types.
        /// </summary>
        /// <value>The MIME types.</value>
        [ConfigurationProperty("ExcludedMimeTypes", IsDefaultCollection = false)]
        public ExcludedMimes ExcludedMimeTypes
        {
            get
            {
                return (ExcludedMimes)base["ExcludedMimeTypes"];
            }
        }

        /// <summary>
        /// Gets the included paths.
        /// </summary>
        /// <value>The paths.</value>
        [ConfigurationProperty("IncludedPaths", IsDefaultCollection = false)]
        public IncludedPaths IncludedPaths
        {
            get
            {
                return (IncludedPaths)base["IncludedPaths"];
            }
        }

        /// <summary>
        /// Gets the included MIME types.
        /// </summary>
        /// <value>The MIME types.</value>
        [ConfigurationProperty("IncludedMimeTypes", IsDefaultCollection = false)]
        public IncludedMimes IncludedMimeTypes
        {
            get
            {
                return (IncludedMimes)base["IncludedMimeTypes"];
            }
        }

        

    }

    /// <summary>
    /// The cache setting
    /// </summary>
    public class Cache : ConfigurationElement
    {
        public Cache(){}
        public Cache(bool cacheFiles,string path) 
        {
            CacheFiles = cacheFiles;
            Path = path;
        }
        /// <summary>
        /// Gets or sets whether to cache files
        /// </summary>
        [ConfigurationProperty("cacheFiles", DefaultValue = false, IsRequired = false)]
        public bool CacheFiles
        {
            get
            { return (bool)this["cacheFiles"]; }
            set
            { this["cacheFiles"] = value; }
        }
        /// <summary>
        /// Gets or sets the path of the cache directory
        /// </summary>
        [ConfigurationProperty("path", DefaultValue = "cache", IsRequired = false)]
        public string Path
        {
            get
            { return (string)this["path"]; }
            set
            { this["path"] = value; }
        }

    }

    /// <summary>
    /// Get paths where javascript and css are stored
    /// </summary>
    public class Paths : ConfigurationElement
    {
        public Paths() { }
        public Paths(string jsPath, string cssPath)
        {
            JsPath = jsPath;
            CssPath = cssPath;
        }
        /// <summary>
        /// Gets or sets the javascript path
        /// </summary>
        [ConfigurationProperty("jsPath", DefaultValue = "javascript", IsRequired = false)]
        public string JsPath
        {
            get
            { return (string)this["jsPath"]; }
            set
            { this["jsPath"] = value; }
        }
        /// <summary>
        /// Gets or sets the css path
        /// </summary>
        [ConfigurationProperty("cssPath", DefaultValue = "css", IsRequired = false)]
        public string CssPath
        {
            get
            { return (string)this["cssPath"]; }
            set
            { this["cssPath"] = value; }
        }

    }

    /// <summary>
    /// A path that is to be excluded from the compression module
    /// </summary>
    public class ExcludedPath : ConfigurationElement
    {

        public ExcludedPath() { }
        public ExcludedPath(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        [ConfigurationProperty("path", IsRequired = true)]
        public string Path
        {
            get
            {
                return (string)base["path"];
            }
            set
            {
                base["path"] = value;
            }
        }

    }

    /// <summary>
    /// The paths to be excluded
    /// </summary>
    public class ExcludedPaths : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ExcludedPath();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ExcludedPath)element).Path;
        }


        /// <summary>
        /// Gets or sets the <see cref="T:ExcludedPath"/> at the specified index.
        /// </summary>
        /// <value></value>
        public ExcludedPath this[int index]
        {
            get { return (ExcludedPath)base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                    base.BaseRemoveAt(index);
                this.BaseAdd(index, value);
            }
        }
        /// <summary>
        /// Determines whether [contains] [the specified path].
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>
        /// 	<c>true</c> if [contains] [the specified path]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string path)
        {
            foreach (ExcludedPath ex in this)
            {
                if (ex.Path.ToLower().Equals(path.ToLower()))
                    return true;
            }
            return false;
        }
    }

    /// <summary>
    /// A mime type to be excluded from the compression module
    /// </summary>
    public class ExcludedMime : ConfigurationElement
    {

        public ExcludedMime() { }
        public ExcludedMime(string mime)
        {
            Mime = mime;
        }

        /// <summary>
        /// Gets or sets the MIME.
        /// </summary>
        /// <value>The MIME.</value>
        [ConfigurationProperty("mime", IsRequired = true)]
        public string Mime
        {
            get
            {
                return (string)base["mime"];
            }
            set
            {
                base["mime"] = value;
            }
        }

    }

    /// <summary>
    /// The mime-types to be excluded
    /// </summary>
    public class ExcludedMimes : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ExcludedMime();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ExcludedMime)element).Mime;
        }


        /// <summary>
        /// Gets or sets the <see cref="T:ExcludedMime"/> at the specified index.
        /// </summary>
        /// <value></value>
        public ExcludedMime this[int index]
        {
            get { return (ExcludedMime)base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                    base.BaseRemoveAt(index);
                this.BaseAdd(index, value);
            }
        }
        /// <summary>
        /// Determines whether [contains] [the specified MIME].
        /// </summary>
        /// <param name="mime">The MIME.</param>
        /// <returns>
        /// 	<c>true</c> if [contains] [the specified MIME]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string mime)
        {
            foreach (ExcludedMime ex in this)
            {
                if (ex.Mime.ToLower().Equals(mime.ToLower()))
                    return true;
            }
            return false;
        }
    }

    /// <summary>
    /// A mime type to be excluded from the compression module
    /// </summary>
    public class IncludedMime : ConfigurationElement
    {

        public IncludedMime() { }
        public IncludedMime(string mime)
        {
            Mime = mime;
        }

        /// <summary>
        /// Gets or sets the MIME.
        /// </summary>
        /// <value>The MIME.</value>
        [ConfigurationProperty("mime", IsRequired = true)]
        public string Mime
        {
            get
            {
                return (string)base["mime"];
            }
            set
            {
                base["mime"] = value;
            }
        }

    }

    /// <summary>
    /// The mime-types to be excluded
    /// </summary>
    public class IncludedMimes : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new IncludedMime();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((IncludedMime)element).Mime;
        }


        /// <summary>
        /// Gets or sets the <see cref="T:ExcludedMime"/> at the specified index.
        /// </summary>
        /// <value></value>
        public IncludedMime this[int index]
        {
            get { return (IncludedMime)base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                    base.BaseRemoveAt(index);
                this.BaseAdd(index, value);
            }
        }
        /// <summary>
        /// Determines whether [contains] [the specified MIME].
        /// </summary>
        /// <param name="mime">The MIME.</param>
        /// <returns>
        /// 	<c>true</c> if [contains] [the specified MIME]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string mime)
        {            
            foreach (IncludedMime ex in this)
            {
                if (ex.Mime.Equals("*") || ex.Mime.ToLower().Equals(mime.ToLower()))
                    return true;
            }
            return false;
        }
    }

    /// <summary>
    /// A path that is to be excluded from the compression module
    /// </summary>
    public class IncludedPath : ConfigurationElement
    {

        public IncludedPath() { }
        public IncludedPath(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        [ConfigurationProperty("path", IsRequired = true)]
        public string Path
        {
            get
            {
                return (string)base["path"];
            }
            set
            {
                base["path"] = value;
            }
        }

    }

    /// <summary>
    /// The paths to be excluded
    /// </summary>
    public class IncludedPaths : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new IncludedPath();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((IncludedPath)element).Path;
        }


        /// <summary>
        /// Gets or sets the <see cref="T:ExcludedPath"/> at the specified index.
        /// </summary>
        /// <value></value>
        public IncludedPath this[int index]
        {
            get { return (IncludedPath)base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                    base.BaseRemoveAt(index);
                this.BaseAdd(index, value);
            }
        }
        /// <summary>
        /// Determines whether [contains] [the specified path].
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>
        /// 	<c>true</c> if [contains] [the specified path]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string path)
        {
            foreach (IncludedPath ex in this)
            {
                if (ex.Path.ToLower().Equals(path.ToLower()))
                    return true;
            }
            return false;
        }
    }
}