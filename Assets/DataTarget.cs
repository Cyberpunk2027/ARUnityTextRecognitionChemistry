using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{



    public class DataTarget : MonoBehaviour
    {

        public Transform TextTargetName;
        public Transform TextDescription;
        string[] temp = new string[10];
        public int djdj = 0;
        public string []scanning = new string[9];
        // Update is called once per frame
        void Update()
        {

            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();
            IEnumerable<TrackableBehaviour> tbs1 = sm.GetActiveTrackableBehaviours();
            IEnumerable<TrackableBehaviour> tbs2 = sm.GetActiveTrackableBehaviours();
            IEnumerable<TrackableBehaviour> tbs3 = sm.GetActiveTrackableBehaviours();
            IEnumerable<TrackableBehaviour> tbs4 = sm.GetActiveTrackableBehaviours();
            IEnumerable<TrackableBehaviour> tbs5 = sm.GetActiveTrackableBehaviours();
            IEnumerable<TrackableBehaviour> tbs6 = sm.GetActiveTrackableBehaviours();





            djdj++;
            Debug.Log("scanning" + djdj );

            //FOREACH UNTUK MENGISI TEMP0 (Terdiri dari 1 unsur)
            foreach (TrackableBehaviour tb in tbs)
            {

      

                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                if (scanning.Length <= 0)
                {
                    scanning[0] = name;
                }
                else
                {
                   for(int i= 0; i<scanning.Length; i++)
                    {
                        if (scanning[i] != name)
                        {
                            scanning[i] = name;
                        }
                    }

                }

                for (int i = 0; i < scanning.Length; i++)
                {
                    Debug.Log("Test Scanning" + scanning[i] );
                }



                //  TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus;
                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //         temp[0] = name;

                Debug.Log("temp0" + temp[0] + "  -size: " + size.x + ", " + size.y);

                for (int i = 1; i <= 8; i++)
                {
                    if (name == ("Ag-" + i) || name == ("Al-" + i) || name == ("Br-" + i) || name == ("C-" + i) || name == ("Ca-" + i) || name == ("Cl-" + i) || name == ("Cr-" + i) || name == ("Cu-" + i)
                        || name == ("F-" + i) || name == ("Fe-" + i) || name == ("H-" + i) || name == ("l-" + i) || name == ("K-" + i) || name == ("Mg-" + i) || name == ("N-" + i) || name == ("Na-" + i) || name == ("O-" + i) || name == ("S-" + i) || name == ("Zn-" + i))
                    {
                        TextTargetName.GetComponent<Text>().text = "Nama Unsur : " + name;
                    }

                }
                if (name == "HCN" || name == "NaOH" || name == "AgBr" || name == "Agl" || name == "Al2O3" || name == "cac2" || name == "CaCO3" || name == "CaO" || name == "CaSO4" || name == "CCl2F2" || name == "CH3Br" || name == "CH3OH" || name == "CHCl3" || name == "CHl3" || name == "Cl2" || name == "CO" || name == "CO2" || name == "CrCl3" || name == "CrO" || name == "CuCl2" || name == "FeO" || name == "H2CO" || name == "H2O" || name == "H2SO4" || name == "HCL" || name == "HCLO" || name == "HF" || name == "HNO3" || name == "K2O" || name == "KBr" || name == "KCl" || name == "KCLO3" || name == "KI" || name == "KlO3" || name == "MgO" || name == "NaBr" || name == "NaCl" || name == "NaClO" || name == "NaClO2" || name == "NaF" || name == "NaHCO3" || name == "NaOCL" || name == "NH3" || name == "NH4Cl" || name == "NO2" || name == "O2" || name == "O3" || name == "SF6" || name == "SO2" || name == "ZnCl2")
                {
                    TextTargetName.GetComponent<Text>().text = "Nama Molekul : " + name;
                }

                TextDescription.gameObject.SetActive(true);
                for (int i = 1; i <= 8; i++)
                {
                    if (name == "Ag-" + i)
                    {
                        TextDescription.GetComponent<Text>().text = "Ini adalah Unsur Ag (Argentum/ Perak)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "H-" + i)
                    {
                        TextDescription.GetComponent<Text>().text = "Ini adalah Unsur H (Hidrogen)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "O-" + i)
                    {
                        TextDescription.GetComponent<Text>().text = "Ini adalah Unsur O (Oksigen)" +
                            "-Jika ditambah 1 unsur O menjadi O2" +
                            "-Jika ditambah 2 unsur O menjadi O3" +
                            "-Silahkan Ambil kartu Molekulnya!";
                        temp[0] = name;
                        break;
                    }

                    if (name == "l-" + i) //ini unsur i tapi ditulis L kecil
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur I(Iodium)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "Na-" + i)
                    {
                        TextDescription.GetComponent<Text>().text = "Ini adalah Unsur Na (Natrium)";
                        temp[0] = name;
                        break;

                    }

                    if (name == "F-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur F (Flour)";
                        temp[0] = name;
                        break;
                    }
                    if (name == "C-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur C (Carbon)";
                        temp[0] = name;
                        break;
                    }
                    if (name == "Cr-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Cr (Chromium/ Kromium)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "Al-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Al (Alumunium)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "Br-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Br (Bromin/ Brom)";
                        temp[0] = name;
                        break;
                    }
                    if (name == "Zn-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Zn (Zink, Seng/ Timah Sari)";
                        temp[0] = name;
                        break;
                    }
                    if (name == "Cu-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Cu (Copper/ Tembaga)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "K-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur K (Kalium)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "Ca-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Ca (Calcium/ Kalsium)";
                        temp[0] = name;
                        break;
                    }
                    if (name == "Fe-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Fe (Ferrum/ Besi)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "Cl-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Cl (Chlorine)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "Mg-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur Mg (Magnesium)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "N-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur N (Nitrogen)";
                        temp[0] = name;
                        break;
                    }

                    if (name == "S-" + i)
                    {

                        TextDescription.GetComponent<Text>().text = "Ini adalah unsur S (Sulfur)";
                        temp[0] = name;
                        break;
                    }
                }
                if (name == "NaCl")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaCl" +
                        "-Fungsi : Natrium Klorida Digunakan untuk Garam dapur";
                    temp[0] = name;
                    break;
                }
                if (name == "H2O")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul H2O" +
                        "-Fungsi : Air Digunakan untuk Air, Pelarut ,dan Pembersih";
                    temp[0] = name;
                    break;
                }
                if (name == "HCL")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul HCL" +
                        "-Fungsi : Asam Klorida Digunakan Untuk Pembersih Lantai";
                    temp[0] = name;
                    break;
                }
                if (name == "H2SO4")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul H2SO4" +
                        "-Fungsi : Asam Sulfat Digunakan Untuk Pengisi Aki ";
                    temp[0] = name;
                    break;
                }
                if (name == "O2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul O2" +
                        "-Fungsi : 	Oksigen Digunakan Untuk Gas Pembantu Pernafasan";
                    temp[0] = name;
                    break;
                }
                if (name == "NaOH")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaOH" +
                        "-Fungsi :  Natrium Klorida Digunakan Untuk industri Sabun, Kertas , Dll";
                    temp[0] = name;
                    break;
                }
                if (name == "NaClO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaClO" +
                        "-Fungsi :	Natrium Hipoklorit Digunakan Untuk Pemutih";
                    temp[0] = name;
                    break;
                }
                if (name == "SO2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul SO2" +
                        "-Fungsi :	Belerang Dioksida Digunakan Untuk Fungisida";
                    temp[0] = name;
                    break;
                }
                if (name == "CO2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CO2" +
                        "-Fungsi :	Karbondioksida Digunakan Untuk Membentuk Minuman Berkarbonat dan Air Soda";
                    temp[0] = name;
                    break;
                }
                if (name == "NaHCO3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaHCO3" +
                        "-Fungsi :	Soda Kue Digunakan Untuk Bahan Pembuat Kue";
                    temp[0] = name;
                    break;
                }
                if (name == "CO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CO" +
                        "-Fungsi :	Karbon Monoksida Digunakan Untuk Reduktor Pada Pengolahan Besi";
                    temp[0] = name;
                    break;
                }
                if (name == "NaOCL")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaOCl" +
                        "-Fungsi :	Pemutih Digunakan Untuk Pemutih Pakaian";
                    temp[0] = name;
                    break;
                }
                if (name == "NO2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NO2" +
                        "-Fungsi : 	Nitrogem Dioksida Digunakan Untuk Katalisator Dalam Penguraian Ozon";
                    temp[0] = name;
                    break;
                }
                if (name == "CuCl2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CuCl2" +
                        "-Fungsi : 	Tembaga Klorida Digunakan Untuk Pewarna Keramik dan gelas, Pabrik Tinta Dan Fotografi";
                    temp[0] = name;
                    break;
                }
                if (name == "HNO3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul HNO3" +
                        "-Fungsi : Asam Nitrat Digunakan Untuk Pembuatan Bahan Peledak";
                    temp[0] = name;
                    break;
                }
                if (name == "HF")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul HF" +
                        "-Fungsi :	Asam Flourida Digunakan Untuk Pembuat Freon ";
                    temp[0] = name;
                    break;
                }
                if (name == "HCN")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul HCN" +
                        "-Fungsi :	Asam Sianida/Hidrogen Sianida Digunakan Untuk Pembasmi Hama dan Obat Obatan ";
                    temp[0] = name;
                    break;
                }
                if (name == "HCLO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul HClO" +
                        "-Fungsi :  Asam Hipoklorit Digunakan Untuk Disinfektan, Agen Pemutih ";
                    temp[0] = name;
                    break;
                }
                if (name == "H2CO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul H2CO" +
                        "-Fungsi : 	Formalin Digunakan Untuk Pengawet Jasad/Kadaver ";
                    temp[0] = name;
                    break;
                }
                if (name == "CHCl3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CHCl3" +
                        "-Fungsi : 	Kloroform Digunakan Untuk Bahan Pembius ";
                    temp[0] = name;
                    break;
                }
                if (name == "CH3OH")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CH3OH" +
                        "-Fungsi :	Metil Alkohol/Metanol Digunakan Untuk Alkohol ";
                    temp[0] = name;
                    break;
                }
                if (name == "cac2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CaC2" +
                        "-Fungsi :  Kalsium Karbida Digunakan Untuk Pembuat Gas Asitelin Untuk Mengelas ";
                    temp[0] = name;
                    break;
                }
                if (name == "CaCO3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CaCO3" +
                        "-Fungsi :  Kalsium Karbonat Digunakan Untuk Mengecat Bangunan  ";
                    temp[0] = name;
                    break;
                }
                if (name == "CrO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CrO" +
                        "-Fungsi :  Kromium (II) Oksida Digunakan Untuk Pewarna dalam Percetakan, Industri, tekstil, dan Keramik ";
                    temp[0] = name;
                    break;
                }
                if (name == "CrCl3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CrCl3" +
                        "-Fungsi :	Kromium (II) Klorida Digunakan Untuk Zat pewarna hijau dalam pembuatan keramik ";
                    temp[0] = name;
                    break;
                }
                if (name == "NH3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NH3" +
                        "-Fungsi :	Amonia Digunakan untuk bahan pembutaan obat-obatan ";
                    temp[0] = name;
                    break;
                }
                if (name == "KCl")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul KCI" +
                        "-Fungsi :	Kalium Klorida Digunakan untuk Pupuk tanaman";
                    temp[0] = name;
                    break;
                }
                if (name == "NaF")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaF" +
                        "-Fungsi :	Natrium Flourida Digunakan untuk Pengawet kayu";
                    temp[0] = name;
                    break;
                }
                if (name == "SF6")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul SF6" +
                        "-Fungsi :	Belerang Hexaflourida Digunakan untuk Insulator";
                    temp[0] = name;
                    break;
                }
                if (name == "NH4Cl")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NH4Cl" +
                        "-Fungsi :	Amonium KloridaDigunakan untuk Bahan Pengisi Baterai";
                    temp[0] = name;
                    break;
                }
                if (name == "NaClO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaClO" +
                        "-Fungsi :	Natrium Hipoklorit Digunakan untuk Breaching Agent untuk kertas dan kain";
                    temp[0] = name;
                    break;
                }
                if (name == "ZnCl2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul ZnCl2" +
                        "-Fungsi :	Seng Klorida Digunakan untuk Bahan Pematri (solder)";
                    temp[0] = name;
                    break;
                }
                if (name == "NaBr")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul NaBr" +
                        "-Fungsi :	Natrium Bromide Digunakan untuk Obat penenang saraf";
                    temp[0] = name;
                    break;
                }
                if (name == "AgBr")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul AgBr" +
                        "-Fungsi :	Perak Bromide Digunakan untuk Film Fotografi";
                    temp[0] = name;
                    break;
                }
                if (name == "CH3Br")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CH3Br" +
                        "-Fungsi :	Metil Bromide Digunakan untuk Zat pemadam kebakaran";
                    temp[0] = name;
                    break;
                }
                if (name == "KlO3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul KIO3" +
                        "-Fungsi :	Kalium Iodat Digunakan untuk Bahan campuran pada garam dapur";
                    temp[0] = name;
                    break;
                }
                if (name == "CHl3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CHI3" +
                        "-Fungsi :	Iodoform Digunakan untuk Zat organic";
                    temp[0] = name;
                    break;
                }
                if (name == "Agl")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul AgI" +
                        "-Fungsi :	Perak Iodida Digunakan untuk Film fotografi";
                    temp[0] = name;
                    break;
                }
                if (name == "MgO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul MgO" +
                        "-Fungsi :	Magnesium Oksida Digunakan untuk Obat penyakit Magg ";
                    temp[0] = name;
                    break;
                }
                if (name == "CaO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CaO" +
                        "-Fungsi :	Kalsium Oksida Digunakan untuk (gamping) industri besi,semen ";
                    temp[0] = name;
                    break;
                }
                if (name == "CaSO4")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CaSO4" +
                        "-Fungsi : Kalsium Sulfat Digunakan untuk Pembuat Gips ";
                    temp[0] = name;
                    break;
                }
                if (name == "Al2O3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul Al2O3" +
                        "-Fungsi : Alumunium Oksida Digunakan untuk  Menggosok besi ";
                    temp[0] = name;
                    break;
                }
                if (name == "O3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul O3" +
                        "-Fungsi : Ozon Digunakan untuk Pemusnah hama air minum ";
                    temp[0] = name;
                    break;
                }
                if (name == "KCLO3")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul KClO3" +
                        "-Fungsi : Kalium Klorat Digunakan untuk Kepala batang korek api ";
                    temp[0] = name;
                    break;
                }
                if (name == "KBr")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul KBr" +
                        "-Fungsi : Kalium Bromide Digunakan untuk Obat-obatan ";
                    temp[0] = name;
                    break;
                }
                if (name == "KI")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul Kl" +
                        "-Fungsi : Kalium Iodida Digunakan untuk Obat-obatan ";
                    temp[0] = name;
                    break;
                }
                if (name == "K2O")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul K2O" +
                        "-Fungsi : Kalium Oksida Digunakan untuk Pembuatan pupuk ";
                    temp[0] = name;
                    break;
                }
                if (name == "CCl2F2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul CCl2F2" +
                        "-Fungsi : Fren-12 Digunakan untuk Zat pendingin pada lemari es dan AC ";
                    temp[0] = name;
                    break;
                }
                if (name == "Cl2")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul Cl2" +
                        "-Fungsi : Disinfektan Digunakan untuk Pembunuh kuman ";
                    temp[0] = name;
                    break;
                }
                if (name == "FeO")
                {

                    TextDescription.GetComponent<Text>().text = "- Ini adalah Molekul FeO" +
                        "-Fungsi : Besi (II)Oksida Digunakan untuk Pewarna Ubin ";
                    temp[0] = name;
                    break;
                }
            }






            //FOREACH UNTUK MENGISI TEMP1 (Terdiri dari 2 unsur)
            foreach (TrackableBehaviour tb1 in tbs1)
            {
                string name = tb1.TrackableName;
                ImageTarget it = tb1.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


                temp[1] = name;
                Debug.Log("temp1" + temp[1] + "  -size: " + size.x + ", " + size.y);
                TextDescription.gameObject.SetActive(true);

                //Untuk kombinasi Molekul Agi
                if ((temp[0] == ("l-1") || temp[0] == ("l-2") || temp[0] == ("l-3")) && (temp[1] == "Ag-1" || temp[1] == "Ag-3" || temp[1] == "Ag-2"))

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (Agi),silahkan ambil kartu molekul (Agi)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }

                //Untuk kombinasi Molekul NaF
                if ((temp[0] == ("Na-1") || temp[0] == ("Na-2") || temp[0] == ("Na-3")) && (temp[1] == "F-1" || temp[1] == "F-3" || temp[1] == "F-2" || temp[1] == "F-4" || temp[1] == "F-5" || temp[1] == "F-6" || temp[1] == "F-7"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaF),silahkan ambil kartu molekul (NaF)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }
                //Untuk kombinasi Molekul NaCl
                if ((temp[0] == ("Na-1") || temp[0] == ("Na-2") || temp[0] == ("Na-3")) && (temp[1] == "Cl-1" || temp[1] == "Cl-2" || temp[1] == "Cl-3" || temp[1] == "Cl-4" || temp[1] == "Cl-5"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaCl),silahkan ambil kartu molekul (NaCl)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul HCl
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && (temp[1] == ("Cl-1")))
                {
                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (HCl),silahkan ambil kartu molekul (HCl)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul HC
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && (temp[1] == ("C-1") /*|| temp[1] == ("C-2") || temp[1] == ("C-3") || temp[1] == ("C-4") || temp[1] == ("C-5")*/))
                {

                    TextDescription.GetComponent<Text>().text = "- Tambahkan Unsur N untuk menjadi molekul (HCN), Silahkan ambil kartu molekul (HCN)!untuk melihat molekulnya" +
                        "- jika ditambah dengan unsur O dapat menjadi molekul (CH3OH), Silahkan ambil kartu molekul (CH3OH)! untuk melihat molekulnya";
                    temp[1] = name;
                    break;
                }


                //Untuk kombinasi Molekul O2
                if ((temp[0] == ("O-1") || (temp[0] == ("O-2")) && (temp[1] == ("O-3") || temp[1] == ("O-4") || temp[1] == ("O-5") || temp[1] == ("O-6"))))
                {

                    TextDescription.GetComponent<Text>().text = "-Ini merupakan molekul (O2), Silahkan ambil kartu (O2)! untuk melihat molekulnya" +
                        "-Jika ditambah 1 unsur O dapat menjadi (O3) Ambil Molekulnya Untuk Melihat Bentuknya!";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul CO
                if ((temp[0] == ("O-2")/* || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")*/) && (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3") ))
                {

                    TextDescription.GetComponent<Text>().text = "- Ini merupakan molekul CO,silahkan ambil kartu molekul (CO)!Untuk Melihat Bentuk Molekulnya" +
                        " Jika ditambah 1 unsur O lagi,menjadi (CO2), Silahkan ambil (CO2)! Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul HF
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && (temp[1] == "F-1" || temp[1] == "F-3" || temp[1] == "F-2" || temp[1] == "F-4" || temp[1] == "F-5" || temp[1] == "F-6" || temp[1] == "F-7"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (HF),silahkan ambil kartu molekul (HF)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul CrO
                if ((temp[0] == ("O-1") || temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) && (temp[1] == ("Cr-1") || temp[1] == ("Cr-2") || temp[1] ==("Cr-3") || temp[1] == ("Cr-4") || temp[1] == ("Cr-5")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CrO),silahkan ambil kartu molekul (CrO)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul AgBr

                if ((temp[0] == "Br-1" || temp[0] == "Br-2" || temp[0] == "Br-3") && (temp[1] == "Ag-1" || temp[1] == "Ag-2" || temp[1] == "Ag-3"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (AgBr),silahkan ambil kartu molekul (AgBr)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul Kl
                if ((temp[0] == ("l-1")) && (temp[1] == ("K-1") || temp[1] == ("K-3") || temp[1] == ("K-2") || temp[1] == ("K-4")))

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (KI),silahkan ambil kartu molekul (KI)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }

                //Untuk kombinasi Molekul CaO
                if ((temp[0] == ("O-2")) && (temp[1] == ("Ca-1") || temp[1] == ("Ca-2") || temp[1] == ("Ca-3")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CaO),silahkan ambil kartu molekul (CaO)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul FeO
                if ((temp[0] == ("O-1") || temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) && (temp[1] == "Fe-1" || temp[1] == "Fe-2" || temp[1] == "Fe-3" || temp[1] == "Fe-4" || temp[1] == "Fe-5"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (FeO),silahkan ambil kartu molekul (FeO)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul KCl
                if ((temp[0] == ("K-1") || temp[0] == ("K-2") || temp[0] == ("K-3") || temp[0] == ("K-4") || temp[0] == ("K-5")) && (temp[1] == "Cl-1" || temp[1] == "Cl-2" || temp[1] == "Cl-3" || temp[1] == "Cl-4" || temp[1] == "Cl-5"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (KCl),silahkan ambil kartu molekul (KCl)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul NaBr
                if ((temp[0] == "Br-1" || temp[0] == "Br-2" || temp[0] == "Br-3" || temp[0] == "Br-4" || temp[0] == "Br-5") && (temp[1] == ("Na-1") || temp[1] == ("Na-2") || temp[1] == ("Na-3")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaBr),silahkan ambil kartu molekul (NaBr)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul MgO
                if ((temp[0] == ("O-1") || temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) && (temp[1] == "Mg-1" || temp[1] == "Mg-2" || temp[1] == "Mg-3"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (MgO),silahkan ambil kartu molekul (MgO)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul KBr
                if ((temp[0] == "Br-1" || temp[0] == "Br-2" || temp[0] == "Br-3" || temp[0] == "Br-4" || temp[0] == "Br-5") && (temp[1] == ("K-1") || temp[1] == ("K-2") || temp[1] == ("K-3") || temp[1] == ("K-4") || temp[1] == ("K-5")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (KBr),silahkan ambil kartu molekul (KBr)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul Cl2
                if ((temp[0] == ("Cl-1") && (temp[1] == "Cl-2" || temp[1] == "Cl-3" || temp[1] == "Cl-4" || temp[1] == "Cl-5")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (Cl2),silahkan ambil kartu molekul (Cl2)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }

                /*Untuk kombinasi Molekul SO
                if ((temp[0] == ("O-1") || temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) && (temp[1] == "S-1" || temp[1] == "S-2" || temp[1] == "S-3"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (SO2),silahkan ambil kartu molekul (SO2)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }*/

                //Untuk kombinasi Molekul NO
                if (/*(temp[0] == ("O-1") || temp[0] == ("O-2") || */temp[0] == ("O-2") /*|| temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")*/ && (temp[1] == "N-1" || temp[1] == "N-2" || temp[1] == "N-3"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (NO), Tambahkan unsur O lagi untuk menjadi molekul (NO2)!";
                    temp[1] = name;
                    break;
                }

                //Untuk kombinasi Molekul SO
                if (/*(temp[0] == ("O-1") || temp[0] == ("O-2") || */temp[0] == ("O-2") /*|| temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")*/ && (temp[1] == "S-1" || temp[1] == "S-2" || temp[1] == "S-3"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (SO), Tambahkan unsur O lagi untuk menjadi molekul (SO2)!";
                    temp[1] = name;
                    break;
                }
                
                //Untuk kombinasi  Unsur CaC
                if (/*(temp[0] == ("O-1") || temp[0] == ("O-2") || */temp[0] == ("Ca-1") /*|| temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")*/ && (temp[1] == "C-1" || temp[1] == "C-2" || temp[1] == "C-3"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (CaC), Tambahkan unsur C lagi untuk menjadi molekul (CaC2)";
                    temp[1] = name;
                    break;
                }
                //Untuk kombinasi Unsur ZnCl
                if (/*(temp[0] == ("O-1") || temp[0] == ("O-2") || */temp[0] == ("Cl-1") /*|| temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")*/ && (temp[1] == "Zn-1" || temp[1] == "Zn-2" || temp[1] == "Zn-3"))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (ZnCl), Tambahkan unsur Cl lagi untuk menjadi molekul (ZnCl2)!";
                    temp[1] = name;
                    break;
                }
               
                //Untuk kombinasi Unsur CrCl
                if ((temp[0] == ("Cl-1") || temp[0] == ("Cl-2") || temp[0] == ("Cl-3") || temp[0] == ("Cl-4") || temp[0] == ("Cl-5")) && (temp[1] == ("Cr-1"))  )
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (CrCl), Tambahkan unsur Cl dua lagi untuk menjadi molekul (CrCl3)";
                    temp[1] = name;
                    break;
                }
                /*//Untuk kombinasi Molekul NH
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && (temp[1] == ("N-1") || temp[1] == ("N-2") || temp[1] == ("N-3")))
                {

                    TextDescription.GetComponent<Text>().text = "Tambahkan Unsur H dua lagi, untuk menjadi molekul NH3 !!";
                    temp[1] = name;
                    break;
                }*/

                //Untuk kombinasi Molekul NaO
                if ((temp[0] == ("O-1") || temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5")) && (temp[1] == ("Na-1") || temp[1] == ("Na-2") || temp[1] == ("N-3")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaOH),silahkan ambil kartu molekul (NaOH)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }
                //Untuk kombinasi Unsur CuCl
                if ((temp[0] == ("Cu-1")) && (temp[1] == ("Cl-1") || temp[1] == ("Cl-2") || temp[1] == ("Cl-3") || temp[1] == ("Cl-4") || temp[1] == ("Cl-5")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (CuCl), Tambahkan unsur Cl lagi untuk menjadi molekul (CuCl2)!";
                    temp[1] = name;
                    break;
                }
                //Untuk kombinasi Molekul Cac
                if ((temp[0] == ("Ca-1") || temp[0] == ("Ca-2") || temp[0] == ("Ca-3")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3"))  
                    )
                {

                    TextDescription.GetComponent<Text>().text = "- Ini merupakan gabungan unsur (CaC), Tambahkan unsur C untuk menjadi molekul (CaC2)" +
                        " jika ditambah unsur (0) maka menjadi molekul (CaCO3), Silahkan ambil molekul kartu (CaCO3)! untuk melihat bentuk molekulnya";
                    temp[1] = name;
                    break;
                }
                //Untuk kombinasi Molekul CCl
                if ((temp[0] == ("Cl-1") || temp[0] == ("Cl-2") || temp[0] == ("Cl-3")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3"))
                    )
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CCl2F2),silahkan ambil kartu molekul (CCl2F2)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;
                }
                //Untuk kombinasi Molekul SF
                if ((temp[0] == ("S-1") || temp[0] == ("S-2") || temp[0] == ("S-3")) &&
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5") || temp[1] == ("F-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (SF6),silahkan ambil kartu molekul (SF6)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }
                //Untuk kombinasi Molekul H2SO4
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) &&
                   (temp[1] == ("S-1") || temp[1] == ("S-2") || temp[1] == ("S-3")) &&
                   (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) 
                   )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (H2SO4),silahkan ambil kartu molekul (H2SO4)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }
                //Untuk kombinasi Molekul CaSO4
                if ((temp[0] == ("S-1") || temp[0] == ("S-2") || temp[0] == ("S-3")) &&
                    (temp[1] == ("Ca-1") || temp[1] == ("Ca-2") || temp[1] == ("Ca-3"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (CaS),silahkan ambil kartu molekul (CaS)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }
                //Untuk kombinasi Molekul KCl
                if ((temp[0] == "Cl-1" || temp[0] == "Cl-2" || temp[0] == "Cl-3" || temp[0] == ("Cl-4") || temp[0] == ("Cl-5")) &&
                    (temp[1] == ("K-1") || temp[1] == ("K-2") || temp[1] == ("K-3")) 
                    )


                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan gabungan unsur (KCl), Tambahkan unsur O untuk menjadi molekul (KClO)!";
                    temp[1] = name;
                    break;

                }
                //Untuk kombinasi Molekul CH3Br
                if ((temp[0] == ("Br-1")) && (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3") || temp[1] == ("C-4") || temp[1] == ("C-5")))

                        {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CH3Br),silahkan ambil kartu molekul (CH3Br)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }
                //Untuk kombinasi Molekul NaHCO3
                if ((temp[0] == ("H-1") || temp[0] == ("H-3") || temp[0] == ("H-2") || temp[0] == ("H-4") || temp[0] == ("H-5") || temp[0] == "H-6")&&
                    (temp[1] == ("Na-1") || temp[1] == ("Na-2") || temp[1] == ("Na-3")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaHCO3),silahkan ambil kartu molekul (NaHCO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }
                //Untuk kombinasi Molekul Al2O3
                if ((temp[0] == ("Al-1")) &&
                    (temp[1] == ("Al-1") || temp[1] == ("Al-2") || temp[1] == ("Al-3"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (Al2O3),silahkan ambil kartu molekul (Al2O3)!Untuk Melihat Bentuk Molekulnya";
                    temp[1] = name;
                    break;

                }



            }







            //FOREACH UNTUK MENGISI TEMP2 (Terdiri dari 3 unsur)
            foreach (TrackableBehaviour tb2 in tbs2)
            {

                string name = tb2.TrackableName;
                ImageTarget it = tb2.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


                temp[2] = name;
                Debug.Log("temp2" + temp[2] + "temp0" + temp[0] + "temp1" + temp[1]);
                TextDescription.gameObject.SetActive(true);

                //Untuk kombinasi Molekul H2O
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && (temp[1] == "H-1" || temp[1] == "H-2" || temp[1] == "H-3" || temp[1] == ("H-4") || temp[1] == ("H-5")) &&
                    (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (H2O),silahkan ambil kartu molekul (H2O)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }

                //Untuk kombinasi Molekul HClO
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && 
                    (temp[1] == "Cl-1" || temp[1] == "Cl-2" || temp[1] == "Cl-3" || temp[1] == ("Cl-4") || temp[1] == ("Cl-5")) &&
                    (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (HClO),silahkan ambil kartu molekul (HClO)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }

                //Untuk kombinasi Molekul HCN
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && 
                    (temp[1] == "C-1" || temp[1] == "C-2" || temp[1] == "C-3" || temp[1] == ("C-4") || temp[1] == ("C-5")) &&
                    (temp[2] == ("N-1") || temp[2] == ("N-2") || temp[2] == ("N-3") || temp[2] == ("N-4") || temp[2] == ("N-5") || temp[2] == ("N-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (HCN),silahkan ambil kartu molekul (HCN)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                
                //Untuk kombinasi Molekul NO2
                if ((temp[0] == ("O-1") || temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) && (temp[1] == "N-1" || temp[1] == "N-2" || temp[1] == "N-3") && (temp[2] == ("O-1") /*|| temp[2] == ("O-2") */|| temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NO2),silahkan ambil kartu molekul (NO2)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;
                }

                //Untuk kombinasi Molekul SO2
                if ((temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) &&
                    (/*|| temp[2] == ("O-2") */ temp[1] == ("O-3") || temp[1] == ("O-4") || temp[1] == ("O-5") || temp[1] == ("O-6")) &&
                    (temp[2] == ("S-1") || temp[2] == ("S-2") || temp[2] == ("S-3")))
                  
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (SO2),silahkan ambil kartu molekul (SO2)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;
                }
              
                //Untuk kombinasi Molekul NaOH
                if ((temp[0] == ("O-2") /*|| temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")*/ &&
                    (temp[1] == ("Na-1") || temp[1] == ("Na-2") || temp[1] == ("Na-3")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5") || temp[2] == ("H-6")) 
                    ))

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaOH),silahkan ambil kartu molekul (NaOH)! Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;
                }

            
                //Untuk kombinasi Molekul NaClO
                 if ((temp[0] == ("O-1") || temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) &&
                    (temp[1] == ("Na-1") || temp[1] == ("Na-2") || temp[1] == ("Na-3")) &&
                     (temp[2] == ("Cl-1") || temp[2] == ("Cl-2") || temp[2] == ("Cl-3") || temp[2] == ("Cl-4") || temp[2] == ("Cl-5") || temp[2] == ("Cl-6")) 
                     )

                    {

                        TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaClO),silahkan ambil kartu molekul (NaClO)! Untuk Melihat Bentuk Molekulnya" +
                        "- Jika strukturnya diubah dapat menjadi molekul (NaOCl), Silahkan ambil kartu molekul (NaOCl)! untuk melihat bentuk molekulnya ";
                        temp[2] = name;
                        break;

                    }
                //Untuk kombinasi Molekul CO2
                if ((temp[0] == ("C-1") || temp[0] == ("C-2") || temp[0] == ("C-3")) &&
                    (temp[1] == ("O-1") || temp[1] == ("O-2") || temp[1] == ("O-3") || temp[1] == ("O-4") || temp[1] == ("O-5") || temp[1] == ("O-6")) &&
                    (temp[2] == ("O-1") || temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))

                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CO2),silahkan ambil kartu molekul (CO2)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul NaOCl
                if ((temp[0] == ("Na-1") || temp[0] == ("Na-2") || temp[0] == ("Na-3")) &&
                    (temp[1] == ("Cl-1") || temp[1] == ("Cl-2") || temp[1] == ("Cl-3") || temp[1] == ("Cl-4") || temp[1] == ("Cl-5") || temp[1] == ("Cl-6")) &&
                    (temp[2] == ("O-1") || temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))

                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NaOCl),silahkan ambil kartu molekul (NaOCl)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul CuCl2
                if ((temp[0] == ("Cu-1") || temp[0] == ("Cu-2") || temp[0] == ("Cu-3")) &&
                    (temp[1] == ("Cl-1") || temp[1] == ("Cl-2") || temp[1] == ("Cl-3") || temp[1] == ("Cl-4") || temp[1] == ("Cl-5") || temp[1] == ("Cl-6")) &&
                    (temp[2] == ("Cl-1") || temp[2] == ("Cl-2") || temp[2] == ("Cl-3") || temp[2] == ("Cl-4") || temp[2] == ("Cl-5") || temp[2] == ("Cl-6")) 
                    
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CuCl2),silahkan ambil kartu molekul (CuCl2)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul CaC2
                if ((temp[0] == ("Ca-1") || temp[0] == ("Ca-2") || temp[0] == ("Ca-3")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3")) &&
                    (temp[2] == ("C-1") || temp[2] == ("C-2") || temp[2] == ("C-3"))
                    
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CaC2),silahkan ambil kartu molekul (CaC2)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul ZnCl2
                if ((temp[0] == ("Cl-1") || temp[0] == ("Cl-2") || temp[0] == ("Cl-3")|| temp[0] == ("Cl-4") || temp[0] == ("Cl-5") || temp[0] == ("Cl-6")) &&
                    (temp[1] == ("Cl-1") || temp[1] == ("Cl-2") || temp[1] == ("Cl-3")|| temp[1] == ("Cl-4") || temp[1] == ("Cl-5") || temp[1] == ("Cl-6")) &&
                    (temp[2] == ("Zn-1") || temp[2] == ("Zn-2") || temp[2] == ("Zn-3")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (ZnCl2),silahkan ambil kartu molekul (ZnCl2)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul K2O
                if ((temp[0] == ("K-1") || temp[0] == ("K-2") || temp[0] == ("K-3") || temp[0] == ("K-4") || temp[0] == ("K-5")) && 
                    (temp[1] == ("K-1") || temp[1] == ("K-2") || temp[1] == ("K-3") || temp[1] == ("K-4") || temp[1] == ("K-5")) &&
                    (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul K2O,silahkan ambil kartu molekul (K2O)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Unsur CrClCl
                if ((temp[0] == "Cl-1" || temp[0] == ("Cl-2") || temp[0] == "Cl-3" || temp[0] == ("Cl-4") || temp[0] == ("Cl-5")) && (temp[1] == "Cl-1" || temp[1] == ("Cl-2") || temp[1] == "Cl-3" || temp[1] == ("Cl-4") || temp[1] == ("Cl-5")) && (temp[2] == ("Cr-1")))
                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul CrCl3,silahkan ambil kartu molekul (CrCl3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;
                }
                //Untuk kombinasi Molekul 
                /*if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5") || temp[0] == ("H-6")) &&
                    (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H-4") || temp[1] == ("H-5") || temp[1] == ("H-6")) &&
                    (temp[2] == ("N-1") || temp[2] == ("N-2") || temp[2] == ("N-3"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Tambahkan unsur H satu lagi, untuk menjadi molekul NH3";
                    temp[2] = name;
                    break;

                }*/
                //Untuk kombinasi Molekul H2CO
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-3") || temp[1] == ("C-4") || temp[1] == ("C-5") || temp[1] == ("C-6")) &&
                    (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) 
                  
                    
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul H2CO,silahkan ambil kartu molekul (H2CO)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul HNO3
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && 
                    (temp[1] == ("N-1") || temp[1] == ("N-2") || temp[1] == ("N-3")) &&
                    (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul HNO3,silahkan ambil kartu molekul (HNO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul CHCl3
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3")) &&
                    (temp[2] == ("Cl-1") || temp[2] == ("Cl-2") || temp[2] == ("Cl-3") || temp[2] == ("Cl-4") || temp[2] == ("Cl-5"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CHCl3),silahkan ambil kartu molekul (CHCl3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul CCl2F2
                if ((temp[0] == ("Cl-1")) &&  (temp[1] == ("F-1")) &&
                    (temp[2] == ("F-1") || temp[2] == ("F-2") || temp[2] == ("F-3") || temp[2] == ("F-4") || temp[2] == ("F-5") || temp[2] == ("F-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CCl2F2),silahkan ambil kartu molekul (CCl2F2)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
               
                //Untuk kombinasi Molekul CHI3
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3") || temp[1] == ("C-4") || temp[1] == ("C-5")) &&
                    (temp[2] == ("l-1") || temp[2] == ("1-2") || temp[2] == ("1-3")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CHI3),silahkan ambil kartu molekul (CHI3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul CaCO3
                if ((temp[0] == ("Ca-1") || temp[0] == ("Ca-2") || temp[0] == ("Ca-3")) && 
                    (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3")) &&
                    (temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CaCO3),silahkan ambil kartu molekul (CaCO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul KlO3
                if ((temp[0] == ("l-1")) &&
                    (temp[1] == ("K-1") || temp[1] == ("K-2") || temp[1] == ("K-3") || temp[1] == ("K-4")) && 
                    (temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6") || temp[2] == ("O-2") || temp[2] == ("O-3"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (KlO3),silahkan ambil kartu molekul (KlO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul Al2O3
                if ((temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) &&
                    (temp[1] == ("Al-1")) && 
                    (temp[2] == ("Al-1") || temp[2] == ("Al-2") || temp[2] == ("Al-3")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (Al2O3),silahkan ambil kartu molekul (Al2O3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul KClO3
                if ((temp[0] == "Cl-1" || temp[0] == "Cl-2" || temp[0] == "Cl-3" || temp[0] == ("Cl-4") || temp[0] == ("Cl-5")) &&
                    (temp[1] == ("K-1") || temp[1] == ("K-2") || temp[1] == ("K-3")) &&
                    (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))
                    )


                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (KClO3),silahkan ambil kartu molekul (KClO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }

                //Untuk kombinasi Molekul SF6
                if ((temp[0] == ("S-1") || temp[0] == ("S-2") || temp[0] == ("S-3")) &&
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5") || temp[1] == ("F-6")) &&
                    (temp[2] == "F-1" || temp[1] == "F-2" || temp[2] == "F-3" || temp[2] == ("F-4") || temp[2] == ("F-5") || temp[2] == ("F-6")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (SF6),silahkan ambil kartu molekul (SF6)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul NaHCO3
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-4")) &&
                    (temp[1] == ("Na-1") || temp[1] == ("Na-2") || temp[1] == ("Na-3")) && 
                    (temp[2] == "C-1" || temp[2] == "C-2" || temp[2] == "C-3") 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul NaHCO3,silahkan ambil kartu molekul (NaHCO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul CH3OH
                if ((temp[0] == ("C-1") || temp[0] == ("C-2") || temp[0] == ("C-3")) && (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H-4") || temp[1] == ("H-5")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5") || temp[2] == ("H-6")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5") || temp[2] == ("H-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CH3OH),silahkan ambil kartu molekul (CH3OH)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }

                //Untuk kombinasi Molekul NH4Cl
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5") || temp[0] == ("H-6")) &&
                    (temp[1] == ("Cl-1") || temp[1] == ("Cl-2") || temp[1] == ("Cl-3")) &&
                    (temp[2] == ("N-1") || temp[2] == ("N-2") || temp[2] == ("N-3"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NH4Cl),silahkan ambil kartu molekul (NH4Cl)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul CaSO4
                if ((temp[0] == ("S-1") || temp[0] == ("S-2") || temp[0] == ("S-3")) &&
                    (temp[1] == ("Ca-1") || temp[1] == ("Ca-2") || temp[1] == ("Ca-3")) &&
                    (temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CaSO4),silahkan ambil kartu molekul (CaSO4)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }
                //Untuk kombinasi Molekul HNO3
                if ((temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5")) && 
                    (temp[1] == ("N-1")) &&
                    (temp[0] == ("O-2"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul HNO3,silahkan ambil kartu molekul (HNO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[2] = name;
                    break;

                }


            }




            //FOREACH UNTUK MENGISI TEMP3 (Terdiri dari 4 unsur)
            foreach (TrackableBehaviour tb3 in tbs3)
            {

                string name = tb3.TrackableName;
                ImageTarget it = tb3.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


                temp[3] = name;
                Debug.Log("temp3" + temp[3] + "temp2" + temp[2] + "temp0" + temp[0] + "temp1" + temp[1]);
                TextDescription.gameObject.SetActive(true);

                //Untuk kombinasi Molekul H2CO
                if ((temp[0] == ("O-2") || temp[0] == ("O-3") || temp[0] == ("O-4") || temp[0] == ("O-5") || temp[0] == ("O-6")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-3") || temp[1] == ("C-4") || temp[1] == ("C-5") || temp[1] == ("C-6")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul H2CO,silahkan ambil kartu molekul (HC2O)!Untuk Melihat Bentuk Molekulnya";
                    temp[3] = name;
                    break;

                }

                //Untuk kombinasi Molekul CrCl3
                if ((temp[3] == ("Cl-1")|| temp[3] == ("Cl-2") || temp[3] == ("Cl-3") || temp[3] == ("Cl-4") || temp[3] == ("Cl-5")) &&
                    (temp[1] == ("Cl-1")) &&
                    (temp[2] == ("Cl-1") || temp[2] == ("Cl-2") || temp[2] == ("Cl-3") || temp[2] == ("Cl-4") || temp[2] == ("Cl-5")) &&
                    (temp[0] == ("Cr-1"))
                  
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CrCl3),silahkan ambil kartu molekul (CrCl3)!Untuk Melihat Bentuk Molekulnya";
                    temp[3] = name;
                    break;

                }

                //Untuk kombinasi Molekul NH3
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && 
                    (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H -4") || temp[1] == ("H-5")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5")) && 
                    (temp[3] == ("N-1"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NH3),silahkan ambil kartu molekul (NH3)!Untuk Melihat Bentuk Molekulnya" +
                        "jika ditammbah unsur (O) maka akan menjadi (HNO3), silakan ambil kartu (HNO3) untuk melihat molekulnya";
                    temp[3] = name;
                    break;

                }

            }



            //FOREACH UNTUK MENGISI TEMP4 (Terdiri dari 5 unsur)
            foreach (TrackableBehaviour tb4 in tbs4)
            {

                string name = tb4.TrackableName;
                ImageTarget it = tb4.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


                temp[4] = name;
                Debug.Log("temp4" + temp[4] + "temp3" + temp[3] + "temp2" + temp[2] + "temp0" + temp[0] + "temp1" + temp[1]);
                TextDescription.gameObject.SetActive(true);


                //Untuk kombinasi Molekul HNO3
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && (temp[1] == ("N-1") || temp[1] == ("N-2") || temp[1] == ("N-3") ) &&
                    (temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) && (temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) && (temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul HNO3,silahkan ambil kartu molekul (HNO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }

                //Untuk kombinasi Molekul CHCl3
                if ((temp[0] == ("C-1") || temp[0] == ("C-2") || temp[0] == ("C-3")) && (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H-4") || temp[1] == ("H-5")) && (temp[2] == ("Cl-1") || temp[2] == ("Cl-2") || temp[2] == ("Cl-3") || temp[2] == ("Cl-4") || temp[2] == ("Cl-5")) &&
                    (temp[3] == ("Cl-1") || temp[3] == ("Cl-2") || temp[3] == ("Cl-3") || temp[3] == ("Cl-4") || temp[3] == ("Cl-5")) && (temp[4] == ("Cl-1") || temp[4] == ("Cl-2") || temp[4] == ("Cl-3") || temp[4] == ("Cl-4") || temp[4] == ("Cl-5")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CHCl3),silahkan ambil kartu molekul (CHCl2)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }

                //Untuk kombinasi Molekul CaCO3
                if ((temp[0] == ("Ca-1") || temp[0] == ("Ca-2") || temp[0] == ("Ca-3")) && (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3") ) &&
                    (temp[2] == ("O-1") || temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) && (temp[3] == ("O-1") || temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) && (temp[4] == ("O-1") || temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CaCO3),silahkan ambil kartu molekul (CaCO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }
                //Untuk kombinasi Molekul KlO3
                if ((temp[0] == ("K-1") || temp[0] == ("K-2") || temp[0] == ("K-3") || temp[0] == ("K-4") ) && (temp[1] == ("l-1") || temp[1] == ("l-2") || temp[1] == ("l-3") ) &&
                    (temp[2] == ("O-1") || temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) && (temp[3] == ("O-1") || temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) && (temp[4] == ("O-1") || temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6"))


                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (KlO3),silahkan ambil kartu molekul (KlO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }
                //Untuk kombinasi Molekul Al2O3
                if ((temp[0] == ("Al-1") || temp[0] == ("Al-2") || temp[0] == ("Al-3")) && (temp[1] == ("Al-1") || temp[1] == ("Al-2") || temp[1] == ("Al-3")) &&
                    (temp[2] == ("O-1") || temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) && 
                    (temp[3] == ("O-1") || temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) && 
                    (temp[4] == ("O-1") || temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6"))


                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (Al2O3),silahkan ambil kartu molekul (Al2O3)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }
                //Untuk kombinasi Molekul KClO3
                if ((temp[0] == ("K-1") || temp[0] == ("K-2") || temp[0] == ("K-3") || temp[0] == ("K-4") ) && (temp[1] == "Cl-1" || temp[1] == "Cl-2" || temp[1] == "Cl-3" || temp[1] == ("Cl-4") || temp[1] == ("Cl-5")) &&
                    (temp[2] == ("O-1") || temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) &&
                    (temp[3] == ("O-1") || temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) &&
                    (temp[4] == ("O-1") || temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (KClO3),silahkan ambil kartu molekul (KClO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }
                //Untuk kombinasi Molekul CCl2F2
                if ((temp[0] == ("C-1") || temp[0] == ("C-2") || temp[0] == ("C-3")) && (temp[1] == ("Cl-1") || temp[1] == ("Cl-2") || temp[1] == ("Cl-3") || temp[1] == ("Cl-4") || temp[1] == ("Cl-5")) &&
                    (temp[2] == ("Cl-1") || temp[2] == ("Cl-2") || temp[2] == ("Cl-3") || temp[2] == ("Cl-4") || temp[2] == ("Cl-5")) &&
                    (temp[3] == ("F-1") || temp[3] == ("F-2") || temp[3] == ("F-3") || temp[3] == ("F-4") || temp[3] == ("F-5") || temp[3] == ("F-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CCl2F2),silahkan ambil kartu molekul (CCl2F2)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }
                //Untuk kombinasi Molekul CH3Br
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5") || temp[0] == ("H-6")) &&
                    (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H-4") || temp[1] == ("H-5") || temp[1] == ("H-6")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5") || temp[2] == ("H-6")) &&
                    (temp[3] == ("C-1") || temp[3] == ("C-2") || temp[3] == ("C-3")) &&
                    (temp[4] == ("Br-1") || temp[4] == ("Br-2") || temp[4] == ("Br-3"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CH3Br),silahkan ambil kartu molekul (CH3Br)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }
                //Untuk kombinasi Molekul CHI3
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) &&
                    (temp[1] == ("C-1") || temp[1] == ("C-2") || temp[1] == ("C-3") || temp[1] == ("C-4") || temp[1] == ("C-5")) &&
                    (temp[2] == ("l-1") || temp[2] == ("1-2") || temp[2] == ("1-3")) &&
                    (temp[3] == ("l-1") || temp[3] == ("1-2") || temp[3] == ("1-3")) &&
                    (temp[4] == ("l-1") || temp[4] == ("1-2") || temp[4] == ("1-3"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CHI3),silahkan ambil kartu molekul (CHI3)!Untuk Melihat Bentuk Molekulnya";
                    temp[4] = name;
                    break;

                }

            }



            //FOREACH UNTUK MENGISI TEMP5 (Terdiri dari 6 unsur)
            foreach (TrackableBehaviour tb5 in tbs5)
            {

                string name = tb5.TrackableName;
                ImageTarget it = tb5.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


                temp[5] = name;
                Debug.Log("temp5" + temp[5] + "temp4" + temp[4] + "temp3" + temp[3] + "temp2" + temp[2] + "temp0" + temp[0] + "temp1" + temp[1]);
                TextDescription.gameObject.SetActive(true);

                //Untuk kombinasi Molekul NaHCO3
                if ((temp[0] == ("Na-1") || temp[0] == ("Na-2") || temp[0] == ("Na-3")) && (temp[1] == "H-1" || temp[1] == "H-2" || temp[1] == "H-3" || temp[1] == ("H-4") || temp[1] == ("H-5")) &&
                    (temp[2] == ("C-1") || temp[2] == ("C-2") || temp[2] == ("C-3")) && 
                    (temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) &&
                    (temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6")) &&
                    (temp[5] == ("O-2") || temp[5] == ("O-3") || temp[5] == ("O-4") || temp[5] == ("O-5") || temp[5] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul NaHCO3,silahkan ambil kartu molekul (NaHCO3)!Untuk Melihat Bentuk Molekulnya";
                    temp[5] = name;
                    break;

                }

                //Untuk kombinasi Molekul CH3OH
                if ((temp[0] == ("C-1") || temp[0] == ("C-2") || temp[0] == ("C-3")) && (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H-4") || temp[1] == ("H-5")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5")) &&
                    (temp[3] == ("H-1") || temp[3] == ("H-2") || temp[3] == ("H-3") || temp[3] == ("H-4") || temp[3] == ("H-5")) &&
                    (temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6")) &&
                    (temp[5] == ("H-1") || temp[5] == ("H-2") || temp[5] == ("H-3") || temp[5] == ("H-4") || temp[5] == ("H-5") || temp[5] == ("H-6")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CH3OH),silahkan ambil kartu molekul (CH3OH)!Untuk Melihat Bentuk Molekulnya";
                    temp[5] = name;
                    break;

                }

                //Untuk kombinasi Molekul NH4Cl
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5") || temp[0] == ("H-6")) &&
                    (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H-4") || temp[1] == ("H-5") || temp[1] == ("H-6")) &&
                    (temp[2] == ("H-1") || temp[2] == ("H-2") || temp[2] == ("H-3") || temp[2] == ("H-4") || temp[2] == ("H-5") || temp[2] == ("H-6")) &&
                    (temp[3] == ("H-1") || temp[3] == ("H-2") || temp[3] == ("H-3") || temp[3] == ("H-4") || temp[3] == ("H-5") || temp[3] == ("H-6")) &&
                    (temp[4] == ("Cl-1") || temp[4] == ("Cl-2") || temp[4] == ("Cl-3") || temp[4] == ("Cl-4") || temp[4] == ("Cl-5")) &&
                    (temp[5] == ("N-1") || temp[5] == ("N-2") || temp[5] == ("N-3") || temp[5] == ("N-4") || temp[5] == ("N-5") || temp[5]== ("N-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (NH4Cl),silahkan ambil kartu molekul (NH4Cl)!Untuk Melihat Bentuk Molekulnya";
                    temp[5] = name;
                    break;

                }
                
                
                //Untuk kombinasi Molekul CaSO4
                if ((temp[0] == ("Ca-1") || temp[0] == ("Ca-2") || temp[0] == ("Ca-3")) && 
                    (temp[1] == ("S-1") || temp[1] == ("S-2") || temp[1] == ("S-3")) &&
                    (temp[2] == ("O-1") || temp[2] == ("O-2") || temp[2] == ("O-3") || temp[2] == ("O-4") || temp[2] == ("O-5") || temp[2] == ("O-6")) &&
                    (temp[3] == ("O-1") || temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) &&
                    (temp[4] == ("O-1") || temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6")) &&
                    (temp[5] == ("O-1") || temp[5] == ("O-2") || temp[5] == ("O-3") || temp[5] == ("O-4") || temp[5] == ("O-5") || temp[5] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (CaSO4),silahkan ambil kartu molekul (CaSO4)!Untuk Melihat Bentuk Molekulnya";
                    temp[5] = name;
                    break;

                }

            }
            //FOREACH UNTUK MENGISI TEMP6 (Terdiri dari 7 unsur)
            foreach (TrackableBehaviour tb6 in tbs6)
            {

                string name = tb6.TrackableName;
                ImageTarget it = tb6.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


                temp[4] = name;
                Debug.Log("temp6" + temp[6] + "temp5" + temp[5] + "temp4" + temp[4] + "temp3" + temp[3] + "temp2" + temp[2] + "temp0" + temp[0] + "temp1" + temp[1]);
                TextDescription.gameObject.SetActive(true);
                //Untuk kombinasi Molekul H2SO4
                if ((temp[0] == ("H-1") || temp[0] == ("H-2") || temp[0] == ("H-3") || temp[0] == ("H-4") || temp[0] == ("H-5")) && 
                    (temp[1] == ("H-1") || temp[1] == ("H-2") || temp[1] == ("H-3") || temp[1] == ("H-4") || temp[1] == ("H-5")) &&
                    (temp[2] == ("S-1") || temp[2] == ("S-2") || temp[2] == ("S-3")) &&
                    (temp[3] == ("O-2") || temp[3] == ("O-3") || temp[3] == ("O-4") || temp[3] == ("O-5") || temp[3] == ("O-6")) &&
                    (temp[4] == ("O-2") || temp[4] == ("O-3") || temp[4] == ("O-4") || temp[4] == ("O-5") || temp[4] == ("O-6")) &&
                    (temp[5] == ("O-2") || temp[5] == ("O-3") || temp[5] == ("O-4") || temp[5] == ("O-5") || temp[5] == ("O-6")) &&
                    (temp[6] == ("O-2") || temp[6] == ("O-3") || temp[6] == ("O-4") || temp[6] == ("O-5") || temp[6] == ("O-6"))
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul H2SO4,silahkan ambil kartu molekul (H2SO4)!Untuk Melihat Bentuk Molekulnya";
                    temp[6] = name;
                    break;

                }

                //Untuk kombinasi Molekul SF6
                if ((temp[0] == ("S-1") || temp[0] == ("S-2") || temp[0] == ("S-3")) && 
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5")|| temp[1] == ("F-6")) &&
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5") || temp[1] == ("F-6")) &&
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5") || temp[1] == ("F-6")) &&
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5") || temp[1] == ("F-6")) &&
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5") || temp[1] == ("F-6")) &&
                    (temp[1] == "F-1" || temp[1] == "F-2" || temp[1] == "F-3" || temp[1] == ("F-4") || temp[1] == ("F-5") || temp[1] == ("F-6")) 
                    )

                {

                    TextDescription.GetComponent<Text>().text = "Ini merupakan molekul (SF6),silahkan ambil kartu molekul (SF6)!Untuk Melihat Bentuk Molekulnya";
                    temp[6] = name;
                    break;

                }
            }
        }
        }
}
