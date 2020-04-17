using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class Controll : MonoBehaviour {
    //SSS
    public Slider speed_scroll; // Объект ползунка скорости
    /*Кнопочки цветов*/ 
    public Color first_color;
    public Color second_color;
    public Color third_color;
    public Color normal_color;
    /*Кнопочки цветов*/

    public GameObject[] Array_buttons = new GameObject[2]; //Массив объектов которые двигаются (кнопок)

    public GameObject triggers_; // массив для попытки использовать триггеры
    //public Active_coubes[] triggers_array; //забудешь же, это массив квадратиков, они пропадают, сейчас идея в том что бы потом считать счетчиком их состояния

    bool check_but = false; // переменная для определения нажатия на кнопочку цвета
    
    public static bool[] num_but = new bool[3]; //массив логических переменных для определения состояния каждого двигающегося объекта  (кнопки)

    public int Level__future_PlayerPrefs; // переменная для перехода на другой уровень (сцену) в будующем изменить ее инициализацию на работу с PlayerPrefs

    void Start()
    { 
        num_but[0] = true;       
    }

    void FixedUpdate()
    {
        if (num_but[0] == true)
        {
            Array_buttons[0].transform.Rotate(0, 0, 1 * speed_scroll.value * 10f); // Создание вращения
        }

        if ((Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) >= 359 & Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) <= 360)
               || Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) >= 179 & Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) <= 181)
        {
            Debug.Log(Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2));
            Debug.Log("You are WINER");
            //SceneManager.LoadScene("2", LoadSceneMode.Single);
        }

        //Debug.Log("Debug_eulerAngels = "+ Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z,2));

    }

    public void First_collor()
    {
        if (check_but==false)
        {
            ColorBlock cb = Array_buttons[0].GetComponent<Button>().colors;
            cb.normalColor = first_color;
            Array_buttons[0].GetComponent<Button>().colors = cb;
            Array_buttons[1].GetComponent<Button>().colors = cb;
            Array_buttons[2].GetComponent<Button>().colors = cb;
            check_but = true;
        }
        else
        {
            ColorBlock cb = Array_buttons[0].GetComponent<Button>().colors;
            cb.normalColor = normal_color;
            Array_buttons[0].GetComponent<Button>().colors = cb;
            Array_buttons[1].GetComponent<Button>().colors = cb;
            Array_buttons[2].GetComponent<Button>().colors = cb;
            check_but = false;
        }
    }
    public void Second_collor()
    {
        if (check_but == false)
        {
            ColorBlock cb = Array_buttons[0].GetComponent<Button>().colors;
            cb.normalColor = second_color;
            Array_buttons[0].GetComponent<Button>().colors = cb;
            Array_buttons[1].GetComponent<Button>().colors = cb;
            Array_buttons[2].GetComponent<Button>().colors = cb;
            check_but = true;
        }
        else
        {
            ColorBlock cb = Array_buttons[0].GetComponent<Button>().colors;
            cb.normalColor = normal_color;
            Array_buttons[0].GetComponent<Button>().colors = cb;
            Array_buttons[1].GetComponent<Button>().colors = cb;
            Array_buttons[2].GetComponent<Button>().colors = cb;
            check_but = false;
        }

     
    }
    public void Third_collor()
    {
        if (check_but == false)
        {
            ColorBlock cb = Array_buttons[0].GetComponent<Button>().colors;
            cb.normalColor = third_color;
            Array_buttons[0].GetComponent<Button>().colors = cb;
            Array_buttons[1].GetComponent<Button>().colors = cb;
            Array_buttons[2].GetComponent<Button>().colors = cb;
            check_but = true;
        }
        else
        {
            ColorBlock cb = Array_buttons[0].GetComponent<Button>().colors;
            cb.normalColor = normal_color;
            Array_buttons[0].GetComponent<Button>().colors = cb;
            Array_buttons[1].GetComponent<Button>().colors = cb;
            Array_buttons[2].GetComponent<Button>().colors = cb;
            check_but = false;
        }


    }

   
     public void Tup_but(string string_of_numbers_eulerAngles)
    {
        double[] arrey_numbers_eulerAngles = new double[3];

        if ((Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) >= 359 & Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) <= 360)
               || Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) >= 179 & Math.Round(Array_buttons[0].GetComponent<RectTransform>().eulerAngles.z, 2) <= 181)
        {
            Debug.Log("You are WINER");
        }

            if (num_but[0] == true)
        {
            num_but[0] = false;
                       
                //SceneManager.LoadScene("2", LoadSceneMode.Single); //Переход на другую сцену
             
        }
        else
        {
            num_but[0] = true;
          
        }
    }

    // Механизм для проверги вхождения в область с помощью триггерров
    //void Check_of_triggers()
    //{
    //    triggers_.SetActive(true);
    //    sum = 0;

    //    for (int i = 0; i < 4; i++)
    //    {
    //        if (triggers_array[i].num_of_HUY == 1)
    //        {
              
    //            Debug.Log("ОБЩАЯ СУУУММА " + sum);
    //            sum++;

    //        }
    //    }

    //    Debug.Log(sum);

    //    if (sum == 4)
    //    {
    //        Debug.Log("Победа");
    //    }
    //    else
    //    {
    //        Debug.Log("Прастити вы дурачек");
    //    }


    //}
}



