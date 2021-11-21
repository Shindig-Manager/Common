using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace ShindigManager.Common.Config;

public class BaseConfig : IBaseConfig
{

	protected readonly IConfiguration? _configuration = null;
	protected readonly IConfigurationRefresher? _refresher = null;

	/// <summary>
	/// Initializes the <see cref="BaseConfig"/> type.
	/// </summary>
	public BaseConfig()
	{
		ConfigurationBuilder? builder = new();
		builder.AddAzureAppConfiguration(options =>
		{
			options.Connect(Environment.GetEnvironmentVariable("ShindigManager_AppConfig_ConnectionString"))
				.Select(KeyFilter.Any, LabelFilter.Null)
				.Select(KeyFilter.Any, Environment.GetEnvironmentVariable("ShindigManager_AppConfig_Environment"))
				.ConfigureRefresh(refresh => { refresh.Register("AppSetting:RefreshDate", true); });
		});
		_configuration = builder.Build();
	}

	/// <summary>
	/// Initialies the <see cref="BaseConfig"/> type using an existing BaseConfig.
	/// </summary>
	/// <param name="baseConfig">The BaseConfig to use for initializing the instance.</param>
	public BaseConfig(BaseConfig baseConfig)
	{
		_configuration = baseConfig._configuration;
	}

	/// <summary>
	/// Tries to refresh the configuration information.
	/// </summary>
	/// <returns><c>True</c> if the configuration information is refreshed.</returns>
	public async Task<bool> TryRefreshAsync()
	{
		return (_refresher is not null) && await _refresher.TryRefreshAsync();
	}

	/// <summary>
	/// Gets the specified configuration value.
	/// </summary>
	/// <param name="key">Key of the configuration value to retrieve.</param>
	/// <returns>The specified configuration value.</returns>
	public string GetConfigValue(string key)
	{
		return _configuration?[key] ?? String.Empty;
	}

}