using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;


namespace kurca4
{
    internal class TGBOT
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("7872756925:AAGdxUWFBpOeoFuIEJP2sIhhWa5LBU-tcoM");

        // Отправка текстового сообщения
        public static async Task SendMessageAsync(string chatId, string message)
        {
            await Bot.SendTextMessageAsync(chatId, message);
        }

        // Отправка изображения
        public static async Task SendPhotoAsync(string chatId, string photoUrl, string caption = "")
        {
            await Bot.SendPhotoAsync(chatId, new InputOnlineFile(photoUrl), caption);
        }

        // Отправка видео
        public static async Task SendVideoAsync(string chatId, string videoUrl, string caption = "")
        {
            await Bot.SendVideoAsync(chatId, new InputOnlineFile(videoUrl), caption);
        }

        // Отправка аудиофайла
        public static async Task SendAudioAsync(string chatId, string audioUrl, string caption = "")
        {
            await Bot.SendAudioAsync(chatId, new InputOnlineFile(audioUrl), caption);
        }

        // Отправка GIF
        public static async Task SendAnimationAsync(string chatId, string gifUrl, string caption = "")
        {
            await Bot.SendAnimationAsync(chatId, new InputOnlineFile(gifUrl), caption);
        }
    }
}

