using UnityEngine;

public static class VectorExtensions
{
    // ----- Vector 3 -----
    /// <summary>Zeroes the x-axis of the vector</summary>
    public static Vector3 ZeroX(this Vector3 vector) => new Vector3(0f, vector.y, vector.z);
    /// <summary>Zeroes the y-axis of the vector</summary>
    public static Vector3 ZeroY(this Vector3 vector) => new Vector3(vector.x, 0f, vector.z);
    /// <summary>Zeroes the z-axis of the vector</summary>
    public static Vector3 ZeroZ(this Vector3 vector) => new Vector3(vector.x, vector.y, 0f);
    /// <summary>Sets the x-axis of the vector</summary>
    /// <param name="value">The value to set the x-axis to</param>
    public static Vector3 SetX(this Vector3 vector, float value) => new Vector3(value, vector.y, vector.z);
    /// <summary>Sets the y-axis of the vector</summary>
    /// <param name="value">The value to set the y-axis to</param>
    public static Vector3 SetY(this Vector3 vector, float value) => new Vector3(vector.x, value, vector.z);
    /// <summary>Sets the z-axis of the vector</summary>
    /// <param name="value">The value to set the z-axis to</param>
    public static Vector3 SetZ(this Vector3 vector, float value) => new Vector3(vector.x, vector.y, value);

    // ----- Vector 2 -----
    /// <summary>Zeroes the x-axis of the vector</summary>
    public static Vector2 ZeroX(this Vector2 vector) => new Vector2(0f, vector.y);
    /// <summary>Zeroes the y-axis of the vector</summary>
    public static Vector2 ZeroY(this Vector2 vector) => new Vector2(vector.x, 0f);
    /// <summary>Creates an equivalent Vector3 with a zeroed z</summary>
    public static Vector3 ZeroZ(this Vector2 vector) => new Vector3(vector.x, vector.y, 0f);
    /// <summary>Sets the x-axis of the vector</summary>
    /// <param name="value">The value to set the x-axis to</param>
    public static Vector2 SetX(this Vector2 vector, float value) => new Vector2(value, vector.y);
    /// <summary>Sets the y-axis of the vector</summary>
    /// <param name="value">The value to set the y-axis to</param>
    public static Vector2 SetY(this Vector2 vector, float value) => new Vector2(vector.x, value);
    /// <summary>Creates an equivalent Vector3 with z set to value</summary>
    /// <param name="value">The value to set the z-axis to</param>
    public static Vector3 SetZ(this Vector2 vector, float value) => new Vector3(vector.x, vector.y, value);
    
    /// <summary>
    /// Rotates a given vector by a given degrees counter-clockwise
    /// </summary>
    /// <param name="degrees">The amount to rotate the vector in degrees</param>
    /// <returns>The rotated vector</returns>
    public static Vector2 RotateVector(this Vector2 vector, float degrees)
    {
        float rotX = Mathf.Cos(degrees * Mathf.Deg2Rad);
        float rotY = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float oldX = vector.x;
        float oldY = vector.y;

        return new Vector2((oldX * rotX) - (oldY * rotY), (oldX * rotY) + (oldY * rotX));
    }
}
