using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boards : MonoBehaviour
{
    //LivingRoom boards
    public GameObject WhiteBoard;
    public GameObject Library;
    
    //Cantina boards
    public GameObject CantinaMessage;
    
    //Cube boards
    public GameObject CubeMessage;

    //Mezzanine boards
    public GameObject BoothMessage;
    public GameObject ImacsMessage;
    
    
    public void openWhiteBoard()
	{
		if (WhiteBoard.activeSelf)
			WhiteBoard.SetActive(false);
		else
			WhiteBoard.SetActive(true);
	}
     public void openlibrary()
	{
		if (Library.activeSelf)
			Library.SetActive(false);
		else
			Library.SetActive(true);
	}

    public void openCantinaMessage()
	{
		if (CantinaMessage.activeSelf)
			CantinaMessage.SetActive(false);
		else
			CantinaMessage.SetActive(true);
	}
    public void openCubeMessage()
	{
		if (CubeMessage.activeSelf)
			CubeMessage.SetActive(false);
		else
			CubeMessage.SetActive(true);
	}
    public void openBoothMessage()
	{
		if (BoothMessage.activeSelf)
			BoothMessage.SetActive(false);
		else
			BoothMessage.SetActive(true);
	}
    public void openImacsMessage()
	{
		if (ImacsMessage.activeSelf)
			ImacsMessage.SetActive(false);
		else
			ImacsMessage.SetActive(true);
	}
}
