using System;
using System.Globalization;
using TMPro;
using UnityEngine;

public class main : MonoBehaviour
{
    private bool isFetched;
    public bool isCurrentDayHighlighted;
    
    [SerializeField] private TMP_Text mesName;
    [SerializeField] private TMP_Text s1;
    [SerializeField] private TMP_Text s2;
    [SerializeField] private TMP_Text s3;
    [SerializeField] private TMP_Text s4;
    [SerializeField] private TMP_Text s5;
    [SerializeField] private TMP_Text s6;
    [Space]
    
    [SerializeField] private TMP_Text r1_d1;
    [SerializeField] private TMP_Text r1_d2;
    [SerializeField] private TMP_Text r1_d3;
    [SerializeField] private TMP_Text r1_d4;
    [SerializeField] private TMP_Text r1_d5;
    [SerializeField] private TMP_Text r1_d6;
    [SerializeField] private TMP_Text r1_d7;
    [Space]

    [SerializeField] private TMP_Text r2_d1;
    [SerializeField] private TMP_Text r2_d2;
    [SerializeField] private TMP_Text r2_d3;
    [SerializeField] private TMP_Text r2_d4;
    [SerializeField] private TMP_Text r2_d5;
    [SerializeField] private TMP_Text r2_d6;
    [SerializeField] private TMP_Text r2_d7;
    [Space]
    
    [SerializeField] private TMP_Text r3_d1;
    [SerializeField] private TMP_Text r3_d2;
    [SerializeField] private TMP_Text r3_d3;
    [SerializeField] private TMP_Text r3_d4;
    [SerializeField] private TMP_Text r3_d5;
    [SerializeField] private TMP_Text r3_d6;
    [SerializeField] private TMP_Text r3_d7;
    [Space]
    
    [SerializeField] private TMP_Text r4_d1;
    [SerializeField] private TMP_Text r4_d2;
    [SerializeField] private TMP_Text r4_d3;
    [SerializeField] private TMP_Text r4_d4;
    [SerializeField] private TMP_Text r4_d5;
    [SerializeField] private TMP_Text r4_d6;
    [SerializeField] private TMP_Text r4_d7;
    [Space]
    
    [SerializeField] private TMP_Text r5_d1;
    [SerializeField] private TMP_Text r5_d2;
    [SerializeField] private TMP_Text r5_d3;
    [SerializeField] private TMP_Text r5_d4;
    [SerializeField] private TMP_Text r5_d5;
    [SerializeField] private TMP_Text r5_d6;
    [SerializeField] private TMP_Text r5_d7;
    [Space]
    
    [SerializeField] private TMP_Text r6_d1;
    [SerializeField] private TMP_Text r6_d2;
    [SerializeField] private TMP_Text r6_d3;
    [SerializeField] private TMP_Text r6_d4;
    [SerializeField] private TMP_Text r6_d5;
    [SerializeField] private TMP_Text r6_d6;
    [SerializeField] private TMP_Text r6_d7;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isCurrentDayHighlighted = false;
        isFetched = false;
        CanFetch();
    }

    void CanFetch()
    {
        bool canFetch = monthChooser.canFetch;
        if (canFetch == true && isFetched == false)
        {
            FetchAndUpdate();
        }
    }
    
    void FetchAndUpdate()
    {
        DateTime today = DateTime.Today;
        int todayInt = DateTime.Today.Day;

        int iteration = monthChooser.itineratedMonth;
        DayOfWeek firstDayOfMonth = new DateTime(today.Year, today.Month + iteration, 1).DayOfWeek;
        string firstDayOfMonth_str = firstDayOfMonth.ToString();

        int firstDayOfWeekOfMonth = 1;
        int lastDayOfMonth = DateTime.DaysInMonth(today.Year, today.Month + iteration);

        if (today.Month + iteration == 1) { mesName.text = "1 - Enero"; }
        if (today.Month + iteration == 2) { mesName.text = "2 - Febrero"; }
        if (today.Month + iteration == 3) { mesName.text = "3 - Marzo"; }
        if (today.Month + iteration == 4) { mesName.text = "4 - Abril"; }
        if (today.Month + iteration == 5) { mesName.text = "5 - Mayo"; }
        if (today.Month + iteration == 6) { mesName.text = "6 - Junio"; }
        if (today.Month + iteration == 7) { mesName.text = "7 - Julio"; }
        if (today.Month + iteration == 8) { mesName.text = "8 - Agosto"; }
        if (today.Month + iteration == 9) { mesName.text = "9 - Septiembre"; }
        if (today.Month + iteration == 10) { mesName.text = "10 - Octubre"; }
        if (today.Month + iteration == 11) { mesName.text = "11 - Noviembre"; }
        if (today.Month + iteration == 12) { mesName.text = "12 - Diciembre"; }
        
        Debug.Log("mes: " + (today.Month + iteration) + " / primer dia del mes: " + firstDayOfMonth + " / ultimo dia del mes: " + lastDayOfMonth);
        
        switch (firstDayOfMonth_str)
        {
            case "Monday": r1_d1.text = "1"; firstDayOfWeekOfMonth = 1; break;
            case "Tuesday": r1_d2.text = "1"; firstDayOfWeekOfMonth = 2; break;
            case "Wednesday": r1_d3.text = "1"; firstDayOfWeekOfMonth = 3; break;
            case "Thursday": r1_d4.text = "1"; firstDayOfWeekOfMonth = 4; break;
            case "Friday": r1_d5.text = "1"; firstDayOfWeekOfMonth = 5; break;
            case "Saturday": r1_d6.text = "1"; firstDayOfWeekOfMonth = 6; break;
            case "Sunday": r1_d7.text = "1"; firstDayOfWeekOfMonth = 7; break;
        }

        r1_d1.text = (1 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (1 + 1 + (firstDayOfWeekOfMonth * -1) <= 0) { r1_d1.text = ""; }
        r1_d2.text = (2 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (2 + 1 + (firstDayOfWeekOfMonth * -1) <= 0) { r1_d2.text = ""; }
        r1_d3.text = (3 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (3 + 1 + (firstDayOfWeekOfMonth * -1) <= 0) { r1_d3.text = ""; }
        r1_d4.text = (4 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (4 + 1 + (firstDayOfWeekOfMonth * -1) <= 0) { r1_d4.text = ""; }
        r1_d5.text = (5 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (5 + 1 + (firstDayOfWeekOfMonth * -1) <= 0) { r1_d5.text = ""; }
        r1_d6.text = (6 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (6 + 1 + (firstDayOfWeekOfMonth * -1) <= 0) { r1_d6.text = ""; }
        r1_d7.text = (7 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (6 + 1 + (firstDayOfWeekOfMonth * -1) <= 0) { r1_d7.text = ""; }
        
        r2_d1.text = (8 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r2_d2.text = (9 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r2_d3.text = (10 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r2_d4.text = (11 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r2_d5.text = (12 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r2_d6.text = (13 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r2_d7.text = (14 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        
        r3_d1.text = (15 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r3_d2.text = (16 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r3_d3.text = (17 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r3_d4.text = (18 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r3_d5.text = (19 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r3_d6.text = (20 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r3_d7.text = (21 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        
        r4_d1.text = (22 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r4_d2.text = (23 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r4_d3.text = (24 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r4_d4.text = (25 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r4_d5.text = (26 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r4_d6.text = (27 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        r4_d7.text = (28 + 1) + (firstDayOfWeekOfMonth * -1) + "";
        
        r5_d1.text = (29 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (30 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r5_d1.text = ""; }
        r5_d2.text = (30 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (31 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r5_d2.text = ""; }
        r5_d3.text = (31 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (32 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r5_d3.text = ""; }
        r5_d4.text = (32 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (33 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r5_d4.text = ""; }
        r5_d5.text = (33 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (34 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r5_d5.text = ""; }
        r5_d6.text = (34 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (35 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r5_d6.text = ""; }
        r5_d7.text = (35 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (36 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r5_d7.text = ""; }
        
        r6_d1.text = (36 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (37 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r6_d1.text = ""; }
        r6_d2.text = (37 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (38 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r6_d2.text = ""; }
        r6_d3.text = (38 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (39 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r6_d3.text = ""; }
        r6_d4.text = (39 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (40 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r6_d4.text = ""; }
        r6_d5.text = (40 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (41 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r6_d5.text = ""; }
        r6_d6.text = (41 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (42 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r6_d6.text = ""; }
        r6_d7.text = (42 + 1) + (firstDayOfWeekOfMonth * -1) + "";  if (43 + firstDayOfWeekOfMonth * -1 > lastDayOfMonth) { r6_d7.text = ""; }

        isFetched = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        CanFetch();
    }
}
