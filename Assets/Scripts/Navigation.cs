using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public GameObject VRcam;

public void goToLivingRoom()
{
    VRcam.transform.position = new Vector3(0, 0, 0);
} 
public void goToCantina()
{
    VRcam.transform.position = new Vector3(40, 0, 0);
} 
public void goToCube()
{
    VRcam.transform.position = new Vector3(20, 0, 0);
} 
public void goToMezzanine()
{
    VRcam.transform.position = new Vector3(60, 0, 0);
} 


}
