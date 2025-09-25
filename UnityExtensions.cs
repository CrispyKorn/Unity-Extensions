using UnityEngine;

public static class UnityExtensions
{
    public static bool Contains(this LayerMask layerMask, int layer)
    {
        // Create a mask with only the layer we are checking
        int singleLayerMask = 1 << layer;
        // Isolate the layerMask so we can easily check the 1 relevant bit for its value
        int isolatedMask = layerMask & singleLayerMask;

        // 0 = not included, 1 = included
        return isolatedMask != 0;
    }

    public static float Sqr(this float f)
    {
        return f * f;
    }

    public static bool Between(this float f, float min, float max)
    {
        return f >= min && f <= max;
    }

    public static bool Between01(this float f)
    {
        return f >= 0f && f <= 1f;
    }
}
