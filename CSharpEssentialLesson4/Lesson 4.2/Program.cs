using System;

namespace Lesson_4._2
{
    /// <summary>
    /// Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов
    /// создайте по 3 метода:void Play()/void Pause()/void Stop() 
    /// и void Record/void Pause()/void Stop() соответственно.
    /// Создайте производный класс Player от базовых интерфейсов Iplayable и IRecodable.
    /// Написать программу, которая выполняет проигрывание и запись.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Player playAndRecord = new Player();
            playAndRecord.Play();
            IPlayable player = playAndRecord as IPlayable;
            player.Pause();
            player.Stop();

            playAndRecord.Record();
            IRecordable recorder = playAndRecord as IRecordable;
            recorder.Pause();
            recorder.Stop();
        }
    }
}
