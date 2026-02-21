using UnityEngine;

public class MathUtils
{
    public static float Remap(
      float value,
      float inMin,
      float inMax,
      float outMin,
      float outMax)
    {
        float t = Mathf.InverseLerp(inMin, inMax, value);
        return Mathf.Lerp(outMin, outMax, t);
    }




    // Clamp 0 -1 

    public static float Clamp01(float value)
    {
        return Mathf.Clamp01(value);
    }



    //distance

    public static float SqrDistance(Vector3 a, Vector3 b)
    {
        return (a - b).sqrMagnitude;
    }


    //Range Detection

    public static bool isWithinRange(Vector3 a, Vector3 b, float range)
    {
        float sqrRange = range * range;

        return (a - b).sqrMagnitude <= sqrRange;

    }


    // Smooth movement
    public static Vector3 SmoothMove(Vector3 current, Vector3 Target, float speed, float deltaTime)
    {
        return Vector3.MoveTowards(Target, current, speed * Time.deltaTime);
    }




    //Angle

    public static float AngleBtw(Vector3 fwd, Vector3 toTarget)
    {
        return Vector3.Angle(fwd, toTarget);
    }


    //Facing

    public static bool isFacingTarget(Transform sourc, Vector3 targPos, float maxAngle)
    {
        Vector3 dir = (targPos - sourc.position).normalized;

        return Vector3.Angle(sourc.forward, dir) <= maxAngle;

    }

    public static bool isWithinCone(Vector3 observePos, Vector3 observerForward, Vector3 targetPos, float maxAngle)
    {
        Vector3 dir = (targetPos - observePos).normalized;
        return AngleBtw(observePos, dir) <= maxAngle;

    }

    //Probability
    public static bool Chance(float probability)
    {

        return Random.value <= (probability);

    }
    //gameplay Curve
    //ability charge 
    public static float EaseInOut(float t)
    {
        return t * t * (3f - 2f * t);
    }


    //throttle tick
    public static bool Tick(
    ref float accumulator,
    float deltaTime,
    float tickInterval)
    {
        accumulator += deltaTime;
        if (accumulator >= tickInterval)
        {
            accumulator -= tickInterval;
            return true;
        }
        return false;
    }


    public static float ComputeZombieSpeed(int zombieCount, float baseSpeed)
    {

        return baseSpeed * Mathf.Sqrt(1f / zombieCount);

    }


    public static float GetTipMultiplier(float normalizedTime)
    {
        return Mathf.Lerp(0.5f, 1.5f,
            Mathf.Pow(normalizedTime, 2f));
    }

}


