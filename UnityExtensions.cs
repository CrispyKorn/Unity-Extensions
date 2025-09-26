using UnityEngine;

public static class UnityExtensions
{
    /// <summary>
    /// Checks whether a LayerMask contains a given layer
    /// </summary>
    /// <param name="layer">The layer to test for</param>
    /// <returns>Whether the LayerMask includes the given layer</returns>
    public static bool Contains(this LayerMask layerMask, int layer)
    {
        // Create a mask with only the layer we are checking
        int singleLayerMask = 1 << layer;
        // Isolate the layerMask so we can easily check the 1 relevant bit for its value
        int isolatedMask = layerMask & singleLayerMask;

        // 0 = not included, 1 = included
        return isolatedMask != 0;
    }

    /// <summary>
    /// Squares the value
    /// </summary>
    /// <returns>The value squared</returns>
    public static float Sqr(this float f)
    {
        return f * f;
    }

    /// <summary>
    /// Checks whether the value lies between two values
    /// </summary>
    /// <param name="min">The minimum bounds of the range</param>
    /// <param name="max">The maximum bounds of the range</param>
    /// <returns>Whether the value is between min and max (inclusive)</returns>
    public static bool Between(this float f, float min, float max)
    {
        return f >= min && f <= max;
    }

    /// <summary>
    /// Checks whether the value lies between 0 and 1
    /// </summary>
    /// <returns>Whether the value is between 0 and 1</returns>
    public static bool Between01(this float f)
    {
        return f.Between(0f, 1f);
    }
}
