
using UnityEngine;

public class VehicleSelect : MonoBehaviour
{
   private int currentVehicle;
    private void SelectVehicle(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }
   public void ChangeVehicle(int _change)
    {
        currentVehicle += _change;
        SelectVehicle(currentVehicle);
    }

}