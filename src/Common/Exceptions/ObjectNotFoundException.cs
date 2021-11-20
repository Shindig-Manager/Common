namespace ShindigManager.Exceptions;

[Serializable]
public class ObjectNotFoundException : Exception
{

	/// <summary>
	/// Gets the name of the object that could not be found.
	/// </summary>
	public string? ObjectName { get; init; }

	/// <summary>
	/// Gets the identifier of the object that could not found.
	/// </summary>
	public string? ObjectId { get; init; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> type.
	/// </summary>
	public ObjectNotFoundException() : base("The object could not be found.") { }

	/// <summary>
	/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> type.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public ObjectNotFoundException(string message) : base(message) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> type.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public ObjectNotFoundException(string message, Exception innerException) : base(message, innerException) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> type.
	/// </summary>
	/// <param name="objectName">Name of the object that could not be found.</param>
	/// <param name="objectId">Identifier of the object that could not be found.</param>
	public ObjectNotFoundException(string objectName, string objectId) : base($"'{objectName} with id '{objectId}' was not found.")
	{
		ObjectName = objectName;
		ObjectId = objectId;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> type.
	/// </summary>
	/// <param name="objectName">Name of the object that could not be found.</param>
	/// <param name="objectId">Identifier of the object that could not be found.</param>
	/// <param name="message">The error message that explain the reason for the exception.</param>
	public ObjectNotFoundException(string objectName, string objectId, string message) : base(message)
	{
		ObjectName = objectName;
		ObjectId = objectId;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> type for a serialized form.
	/// </summary>
	/// <param name="info">The serialization info.</param>
	/// <param name="context">The streaming context being used.</param>
	protected ObjectNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }

}