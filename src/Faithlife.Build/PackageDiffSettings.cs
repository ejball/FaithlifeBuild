using System;

namespace Faithlife.Build
{
	/// <summary>
	/// The settings to use when using PackageDiff.
	/// </summary>
	public sealed class PackageDiffSettings
	{
		/// <summary>
		/// The version of the <c>packagediff</c> tool to use when testing packages.
		/// </summary>
		/// <remarks>Defaults to a stable version, which may change with new versions of <b>Faithlife.Build</b>,
		/// but will not change unless <b>Faithlife.Build</b> is updated.</remarks>
		public string ToolVersion { get; set; }

		/// <summary>
		/// A function that returns true if the semver should be tested for the package with the specified name.
		/// </summary>
		/// <remarks>If not specified, all packages will be tested.</remarks>
		public Func<string, bool> ShouldTestPackage { get; set; }

		/// <summary>
		/// Returns the default settings.
		/// </summary>
		public static PackageDiffSettings Default => new PackageDiffSettings();

		/// <summary>
		/// Clones the settings.
		/// </summary>
		public PackageDiffSettings Clone() => (PackageDiffSettings) MemberwiseClone();
	}
}
