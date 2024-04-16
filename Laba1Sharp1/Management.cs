using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
    /// <summary>
    /// Интерфейс, определяющий поведение Органов управления
    /// </summary>
    interface Management
    {

        /// <summary>
        /// Метод, для отправки запроса на увеличение библиотеки
        /// </summary>
        /// <param name="nameOfLibrary"> Наименование библиотеки</param>
        void extensionRequest(string nameOfLibrary);

        /// <summary>
        /// Метод, для отправки заявок на увеличениф фонда библиотеки
        /// </summary>
        /// <param name="nameOfLibrary"></param>
        void increaseBooksRequest(string nameOfLibrary);

        /// <summary>
        /// Метод для получения имени органа управления
        /// </summary>
        /// <returns>Имя</returns>
        String getName();

    }
}
