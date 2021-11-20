namespace ShindigManager.Exceptions;

/// <summary>
/// An exception that is thrown when an error is encountered while saving to the data persistence layer.
/// </summary>
[Serializable]
public class PersistenceUpdateException : Exception
{

	/// <summary>
	/// Initializes a new instance of the <see cref="PersistenceUpdateException"/> type.
	/// </summary>
	public PersistenceUpdateException() : base("An error occurred while saving the changes.") { }

	/// <summary>
	/// Initializes a new instance of the <see cref="PersistenceUpdateException"/> type.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public PersistenceUpdateException(string message) : base(message) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="PersistenceUpdateException"/> type.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public PersistenceUpdateException(string message, Exception innerException) : base(message, innerException) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="PersistenceUpdateException"/> type.
	/// </summary>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public PersistenceUpdateException(Exception innerException) : base("An error occurred while saving the entity changes. See the inner exception for details.", innerException) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="PersistenceUpdateException"/> type for a serialized form
	/// </summary>
	/// <param name="info">The serialization info</param>
	/// <param name="context">The streaming context being used.</param>
	protected PersistenceUpdateException(SerializationInfo info, StreamingContext context) : base(info, context) { }

}