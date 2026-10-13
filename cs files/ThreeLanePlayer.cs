
using UnityEngine;

public class ThreeLanePlayer : MonoBehaviour
{
    [Header("Row Positions (World Y)")]
    public float bottomY = -2f;
    public float middleY = 0f;
    public float topY = 2f;

    [Header("Movement")]
    public float moveSpeed = 8f;

    // 0 = Bottom, 1 = Middle, 2 = Top
    private int currentRow = 1;
    private float targetY;

    void Start()
    {
        // Start in the middle row
        targetY = middleY;

        Vector3 position = transform.position;
        position.y = middleY;
        transform.position = position;
    }

    void Update()
    {
        // Smoothly move toward the selected row
        Vector3 position = transform.position;

        position.y = Mathf.MoveTowards(
            position.y,
            targetY,
            moveSpeed * Time.deltaTime
        );

        transform.position = position;
    }

    // Connect this method to the UP button
    public void MoveUp()
    {
        if (currentRow < 2)
        {
            currentRow++;
            UpdateTargetRow();
        }
    }

    // Connect this method to the DOWN button
    public void MoveDown()
    {
        if (currentRow > 0)
        {
            currentRow--;
            UpdateTargetRow();
        }
    }

    void UpdateTargetRow()
    {
        if (currentRow == 0)
            targetY = bottomY;
        else if (currentRow == 1)
            targetY = middleY;
        else
            targetY = topY;
    }
}
