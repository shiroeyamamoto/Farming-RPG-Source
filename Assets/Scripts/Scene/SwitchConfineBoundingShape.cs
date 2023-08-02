using Cinemachine;
using UnityEngine;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SwitchBoundingShape();
    }
    /// <summary>
    /// Switch va chạm giúp cinemachine có thể xác định được các cạnh của màn hình
    /// </summary>
    private void SwitchBoundingShape()
    {
        // Sử dụng polygon collision với tag name "BoundsFiner" đã tạo để prevent(ngăn) cinemachine going beyond the scene
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();

        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();

        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        //Dọn cache khi có thay đổi confiner 

        cinemachineConfiner.InvalidatePathCache();

    }
}
