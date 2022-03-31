﻿// // <copyright file="SettingsData.cs" company="PublicDomainWeekly.com">
// //     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
// //     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// // </copyright>
// // <auto-generated />

namespace PublicDomain
{
    // Directives
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;

    /// <summary>
    /// Urlister settings.
    /// </summary>
    public class SettingsData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:PublicDomain.SettingsData"/> class.
        /// </summary>
        public SettingsData()
        {
            // Parameterless constructor
        }

        /// <summary>
        /// The top most.
        /// </summary>
        public bool TopMost { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:PublicDomain.SettingsData"/> backup files.
        /// </summary>
        /// <value><c>true</c> if backup files; otherwise, <c>false</c>.</value>
        public bool BackupFiles { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:PublicDomain.SettingsData"/> check on click.
        /// </summary>
        /// <value><c>true</c> if check on click; otherwise, <c>false</c>.</value>
        public bool CheckOnClick { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:PublicDomain.SettingsData"/> load files on start.
        /// </summary>
        /// <value><c>true</c> if load files on start; otherwise, <c>false</c>.</value>
        public bool LoadFilesOnStart { get; set; } = true;

        /// <summary>
        /// Gets or sets the root directory.
        /// </summary>
        /// <value>The root directory.</value>
        public string RootDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the script program.
        /// </summary>
        /// <value>The script program.</value>
        public string ScriptProgram { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the intermediate file.
        /// </summary>
        /// <value>The intermediate file.</value>
        public string IntermediateFile { get; set; } = string.Empty;
    }
}