public static class PasswordHash  
{
    /// <summary>
    /// Get a random salt string to use when hashing a password.
    /// </summary>
    /// <returns>The string representation of the salt.</returns>
    private static string GetRandomSalt() => BCrypt.Net.BCrypt.GenerateSalt(12);

    /// <summary>
    /// Hashes the password to store the crypted value.
    /// </summary>
    /// <param name="password">The password to hash.</param>
    /// <returns>The hashed value of the password.</returns>
    public static string HashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());

    /// <summary>
    /// Verify if the entered password corresponds to the stored hash value.
    /// </summary>
    /// <param name="password">The inserted password.</param>
    /// <param name="correctHash">The stored correct password hash.</param>
    /// <returns>True if hashed values correspond, otherwise false.</returns>
    public static bool ValidatePassword(string password, string correctHash) => BCrypt.Net.BCrypt.Verify(password, correctHash);
}
