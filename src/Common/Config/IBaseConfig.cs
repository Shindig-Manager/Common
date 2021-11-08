namespace ShindigManager.Common.Config;

/// <summary>
/// Interface used by the BaseConfig.
/// </summary>
public interface IBaseConfig
{

	/// <summary>
	/// Gets the specified configuration value.
	/// </summary>
	/// <param name="key">Key of the configuration value to retrieve.</param>
	/// <returns>The specified configuration value.</returns>
	string GetConfigValue(string key);

	/// <summary>
	/// Tries to refersh the configuration information.
	/// </summary>
	/// <returns><c>True</c> if the configuration information is refreshed.</returns>
	Task<bool> TryRefreshAsync();

}