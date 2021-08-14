﻿using System.IO;
using TXFileManager.Utils;

namespace TXFileManager.Operations
{
    /// <summary>
    /// Rollbackable operation which copies a file.
    /// </summary>
    sealed class Copy : SingleFileOperation
    {
        private readonly string sourceFileName;
        private readonly bool overwrite;

        /// <summary>
        /// Instantiates the class.
        /// </summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file.</param>
        /// <param name="overwrite">true if the destination file can be overwritten, otherwise false.</param>
        public Copy(string sourceFileName, string destFileName, bool overwrite)
            : base(destFileName)
        {
            this.sourceFileName = sourceFileName;
            this.overwrite = overwrite;
        }

        public override void Execute()
        {
            if (File.Exists(path))
            {
                string temp = FileUtils.GetTempFileName(Path.GetExtension(path));
                File.Copy(path, temp);
                backupPath = temp;
            }

            File.Copy(sourceFileName, path, overwrite);
        }
    }
}
