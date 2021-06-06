using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }
    private Vector2 SnapToGrid(Vector2 rawWolrdPos)
    {
        float newX = Mathf.RoundToInt(rawWolrdPos.x);
        float newY = Mathf.RoundToInt(rawWolrdPos.y);
        return new Vector2(newX, newY);
    }
    private void SpawnDefender(Vector2 roundedPos)
    {
        Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
    }
}
