﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4._2
{
    /// <summary>
    /// Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов
    /// создайте по 3 метода:void Play()/void Pause()/void Stop() 
    /// и void Record/void Pause()/void Stop() соответственно.
    /// Создайте производный класс Player от базовых интерфейсов Iplayable и IRecodable.
    /// Написать программу, которая выполняет проигрывание и запись.
    /// </summary>
    interface IRecordable
    {
        void Pause();
        void Stop();
        void Record();
    }
}
