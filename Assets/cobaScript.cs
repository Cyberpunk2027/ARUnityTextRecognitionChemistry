using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobaScript : MonoBehaviour {
	public float scalingSpeed = 0.01f; // mengatur sekla kecepatan
	public float rotationSpeed = 70.0f; // mengatur kecepatan rotasi
	public float translationSpeed = 5.0f; // mengatur kecepatan terjemah

	//	public GameObject Model-->list fungsi yang dapat digunakan dengan perulangan;

	bool repeatScaleUp = false;  //mengulangi penikatan = salah
	bool repeatScaleDown = false; //mengulangi penurunan = salah
	bool repeatRotateLeft = false; //mengulangi putar kiri = salah
	bool repeatRotateRight = false; //mengulangi putar kanan = salah
	bool repeatPositionUp = false; // mengulangi posisi atas = salah
	bool repeatPositionDown = false; //mengulagi posisi bawah = salah
	bool repeatPositionLeft = false; //mengulangi posisi kiri = salah
	bool repeatPositionRight = false; //mengulagi posisi kanan = salah
	bool repeatRotateUp = false;


	void Update ()
	//jika (mengulangi penikatan) tombol penikatan
	{

		if (repeatRotateUp)
		{
			RotationUpButton();
		}

		if (repeatScaleUp) {
			ScaleUpButton ();
		}
		//jika(mengulangi penurunan) tombol penurunan

		if (repeatScaleDown) {
			ScaleDownButton ();
		}
		//jika (mengulangi putar kanan) tombol putar kiri

		if (repeatRotateRight) {
			RotationRightButton();
		}
		//jika (mengulangi putar kiri) tombol putar kiri

		if (repeatRotateLeft) {
			RotationLeftButton();
		} 
		//jika (mengulangi posisi atas) tombol posisi atas

		if (repeatPositionUp) {
			PositionUpButton();
		}
		//jika (mengulangi posisi bawah) tombol posisi bawah

		if (repeatPositionDown) {
			PositionDownButton();
		} 
		//jika (mengulangi posisi kiri) tombol posisi kiri

		if (repeatPositionLeft) {
			PositionLeftButton();
		}
		//jika (mengulangi posisi kana) tombol posisi kanan

		if (repeatPositionRight) {
			PositionRightButton();
		}

	}

	// Fungsi untuk menutup app button
	public void CloseAppButton ()
	{
		Application.Quit ();
	}
	// Fungsi untuk memutar ke arah kanan
	public void RotationRightButton ()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);



		for (int i = 1; i <= 119; i ++)
		{
			GameObject.FindWithTag("Model"+i).transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);

		}


	}

	public void RotationUpButton()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);



		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model" + i).transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime, 0);

		}


	}



	//fungsi membuat tombol putar kiri
	public void RotationLeftButton ()
	{
		// transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model"+i).transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
		}
	} 
	//fungsi membuat tombol ulangi putar kanan
	public void RotationRightButtonRepeat ()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
		repeatRotateRight=true;
	}

	public void RotationUpButtonRepeat()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
		repeatRotateUp = true;
	}
	//fungsi membuat tombol ulangi putar kiri
	public void RotationLeftButtonRepeat ()
	{
		// transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		repeatRotateLeft=true;
	}
	//fumgsi membuat tombol penaikan
	public void ScaleUpButton ()
	{
		// transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model"+i).transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
		}
	}
	//fungsi membuat tombol ulang penaikan
	public void ScaleUpButtonRepeat ()
	{
		repeatScaleUp = true;
		Debug.Log ("Up");
	}
	//fungsi membuat tomol ulang penurunan
	public void ScaleDownButtonRepeat ()
	{
		repeatScaleDown = true;
		Debug.Log ("Down");
	}
	//fungsi membuat tombol ulang posisi bawah
	public void PositionDownButtonRepeat ()
	{
		repeatPositionDown = true;
	} 
	//fungsi membuat tombol ulang posisi atas 
	public void PositionUpButtonRepeat ()
	{
		repeatPositionUp = true;
	}
	//fungsi membuat tombol ulang posisi kiri
	public void PositionLeftButtonRepeat ()
	{
		repeatPositionLeft = true;
	}
	//fungsi membuat tombol ulang posisi kanan
	public void PositionRightButtonRepeat ()
	{
		repeatPositionRight = true;
	} 
	//fungsi membuat tombol penaikan off
	public void ScaleUpButtonOff ()
	{
		repeatScaleUp = false;
		Debug.Log ("Off");
	}
	//fungsi membuat tombol penurunan off
	public void ScaleDownButtonOff ()
	{
		repeatScaleDown = false;
		Debug.Log ("Off");
	}
	//fungsi membuat tombol putar kiri off
	public void RotateLeftButtonOff ()
	{
		repeatRotateLeft = false;
		Debug.Log ("Off");
	}
	//fungsi membuat tombol putar kanan off
	public void RotateRightButtonOff ()
	{
		repeatRotateRight = false;
		Debug.Log ("Off");
	}
	//fungsi membuat tombol posisi kanan off
	public void PositionRightButtonOff ()
	{
		repeatPositionRight = false;
		Debug.Log ("Off");
	}
	//fungsi membuat tombol posisi kiri off
	public void PositionLeftButtonOff ()
	{
		repeatPositionLeft = false;
		Debug.Log ("Off");
	}
	//fungsi membuat tombol posisi atas off
	public void PositionUpButtonOff ()
	{
		repeatPositionUp = false;
		Debug.Log ("Off");
	}
	//fungsi membuat tombol posisi bawah off
	public void PositionDownButtonOff ()
	{
		repeatPositionDown = false;
		Debug.Log ("Off");
	}


	//ANIMASI OOOOFFFFFFF
	public void AnimasiOff()
	{
		repeatScaleUp = false;  //mengulangi penikatan = salah
		repeatScaleDown = false; //mengulangi penurunan = salah
		repeatRotateLeft = false; //mengulangi putar kiri = salah
		repeatRotateRight = false; //mengulangi putar kanan = salah
		repeatPositionUp = false; // mengulangi posisi atas = salah
		repeatPositionDown = false; //mengulagi posisi bawah = salah
		repeatPositionLeft = false; //mengulangi posisi kiri = salah
		repeatPositionRight = false; //mengulagi posisi kanan = salah
		repeatRotateUp = false;
		Debug.Log("Off");
	}


	//fungsi membuat tombol penurunan 
	public void ScaleDownButton ()
	{
		// transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model"+i).transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
		}

	}
	//fungsi membuat tombol posisi atas 
	public void PositionUpButton ()
	{
		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model"+i).transform.Translate(0, 0, -translationSpeed * Time.deltaTime);
		}
	} 
	//fungsi membuat tombol posisi bawah
	public void PositionDownButton ()

	{
		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model"+i).transform.Translate(0, 0, translationSpeed * Time.deltaTime);
		}
	} 
	//fungsi membut tombol posisi kanan
	public void PositionRightButton ()
	{
		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model"+i).transform.Translate(-translationSpeed * Time.deltaTime, 0, 0);
		}
	}
	//fungsi membuat tombol posisi kiri
	public void PositionLeftButton ()
	{
		for (int i = 1; i <= 119; i++)
		{
			GameObject.FindWithTag("Model"+i).transform.Translate(translationSpeed * Time.deltaTime, 0, 0);  // backward
		}
	} 
	//fungsi untuk merubah scene
	public void ChangeScene (string a)
	{
		Application.LoadLevel (a); //aplikasi
	}
	//fungsi untuk membuat tombol apa saja
	public void AnyButton ()
	{
		Debug.Log ("Any");
	}
}
