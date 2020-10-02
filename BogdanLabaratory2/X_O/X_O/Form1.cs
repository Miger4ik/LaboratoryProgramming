using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O
{
    public partial class Form1 : Form
    {
        // кількість полів на екрані
        int gameAreaNumber = 9;
        // кількість елементів в діагоналі
        int diagonalElementNumber = 3;

        // координати всіх діагоналей ігрового поля
        int[,] diagonals = 
            {
                {0, 1, 2},  // X X X
                            // O O O
                            // O O O

                {3, 4, 5},  // O O O
                            // X X X
                            // O O O

                {6, 7, 8},  // O O O
                            // O O O
                            // X X X

                {0, 3, 6},  // X O O
                            // X O O
                            // X O O

                {1, 4, 7},  // O X O
                            // O X O
                            // O X O

                {2, 5, 8},  // O O X
                            // O O X
                            // O O X

                {0, 4, 8},  // X O O
                            // O X O
                            // O O X

                {2, 4, 6}   // O O X
                            // O X O
                            // X O O
            };

        // кількість всіх переможних діагоналей
        int diagonalsLenght;

        // матриця поля гравця
        private int[] playerGameMap =
        {
            0, 0, 0,
            0, 0, 0,
            0, 0, 0
        };

        // матриця поля компа
        private int[] computerGameMap =
        {
            0, 0, 0,
            0, 0, 0,
            0, 0, 0
        };

        // константи гравця та компа
        private const int PLAYER_MARK = 1;
        private const int COMP_MARK = 2;

        // константи рівня складності
        private const int EASY_DIFFICULT_MARK = 1;
        private const int MIDDLE_DIFFICULT_MARK = 2;
        private const int HARD_DIFFICULT_MARK = 3;

        // стандартний рівень складності
        private int difficultMark = 1;

        public Form1()
        {
            InitializeComponent();

            // обнуляємо текст з результатом гри
            resultText.Text = "";

            // визначаємо кількість переможних діагоналей
            diagonalsLenght = diagonals.Length / diagonalElementNumber;

            // встановлюємо початковий розмір вікна
            this.Size = new Size(700, 450);

            // встановлюємо початковий стан гри
            stopGame();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            // отримуємо текст кнопки на яку нажав гравець
            var buttonText = sender.GetType().GetProperty("Text").GetValue(sender).ToString();

            // перевіряємо чи кнопка пуста
            if (buttonText.Equals(""))
            {
                var buttonName = sender.GetType().GetProperty("Name").GetValue(sender).ToString();
                var buttonCoordinate = getCoordinat(buttonName);
                addMarkInMatrix(1, buttonCoordinate);
                // блокуємо екран для ходу компа та розрахування результату
                loockGame();
                // перевіряємо чи переміг гравець
                if (checkWin(PLAYER_MARK))
                {
                    gameWin(PLAYER_MARK);
                    stopGame();
                }
                // перевіряємо чи настала нічия
                else if (checkDraw())
                {
                    gameDraw();
                    stopGame();
                }
                // якщо гравець не переміг і не настала нічия робимо хід компа
                else
                {
                    compStep(difficultMark);
                    // після ходу компа перевіряємо чи він не переміг
                    // якщо переміг зупиняємо гру
                    if (checkWin(COMP_MARK))
                    {
                        gameWin(COMP_MARK);
                        stopGame();
                    }
                    // якщо комп не переміг продовжуємо гру
                    else
                    {
                        unlockGame();
                    }
                }
                
            }
        }

        // метод який визначає значення радіо кнопок
        private void getDataFromRadio(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                switch(radioButton.Text)
                {
                    case "Easy":
                        difficultMark = 1;
                        break;
                    case "Middle":
                        difficultMark = 2;
                        break;
                    case "Hard":
                        difficultMark = 3;
                        break;
                }
                
            }
        }

        // метод який перезапускає гру
        private void startGame()
        {
            // обнулюємо значення всіх кнопок
            button1_1.Text = "";
            button1_2.Text = "";
            button1_3.Text = "";

            button2_1.Text = "";
            button2_2.Text = "";
            button2_3.Text = "";

            button3_1.Text = "";
            button3_2.Text = "";
            button3_3.Text = "";

            // обнулюємо значення активних полів в памяті
            for (int i = 0; i < gameAreaNumber; i++)
            {
                playerGameMap[i] = 0;
                computerGameMap[i] = 0;
            }

            // забираємо надпис про результат гри
            resultText.Text = "";

            // змінюємо надпис на кнопці
            buttonStart.Text = "Restart Game";

            // блокуємо вибір складності гри
            radioButtonEasy.Enabled = false;
            radioButtonMiddle.Enabled = false;
            radioButtonHard.Enabled = false;

            // розблоковуємо ігрове поле
            unlockGame();
        }

        // метод який робить всі ігрові поля активними
        private void loockGame()
        {
            button1_1.Enabled = false;
            button1_2.Enabled = false;
            button1_3.Enabled = false;

            button2_1.Enabled = false;
            button2_2.Enabled = false;
            button2_3.Enabled = false;

            button3_1.Enabled = false;
            button3_2.Enabled = false;
            button3_3.Enabled = false;
        }

        // метод який робить всі ігрові поля неактивними
        private void unlockGame()
        {
            button1_1.Enabled = true;
            button1_2.Enabled = true;
            button1_3.Enabled = true;

            button2_1.Enabled = true;
            button2_2.Enabled = true;
            button2_3.Enabled = true;

            button3_1.Enabled = true;
            button3_2.Enabled = true;
            button3_3.Enabled = true;
        }
        // метод для зупинки гри
        private void stopGame()
        {
            loockGame();
            buttonStart.Text = "Start Game";

            // розблокуємо вибір складності гри
            radioButtonEasy.Enabled = true;
            radioButtonMiddle.Enabled = true;
            radioButtonHard.Enabled = true;
        }

        // метод для оголошення нічиї
        private void gameDraw()
        {
            resultText.Text = "Draw";
            stopGame();
        }

        // метод для визначення нічиї
        private bool checkDraw()
        {
            for(int i = 0; i < gameAreaNumber; i++)
            {
                if(playerGameMap[i] == 0 && computerGameMap[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // метод для оголошення перемоги
        private void gameWin(int player)
        {
            switch (player)
            {
                case PLAYER_MARK:
                    resultText.Text = "You Win";
                    break;

                case COMP_MARK:
                    resultText.Text = "You Lose";
                    break;
            }
        }

        // метод для визначення перемоги
        private bool checkWin(int player)
        {
            // оголошуємо локальні змінні для роботи
            int[] tempMap = new int[8];
            int winFlag = 0;

            // визначаємо гравця чи компютера перевіряємо на перемогу
            // якщо методу переданий 1 значить обчислюємо матрицю гравця
            // якщо передана двійка значить обчислюємо компютер
            switch (player)
            {
                case PLAYER_MARK:
                    tempMap = playerGameMap;
                    break;

                case COMP_MARK:
                    tempMap = computerGameMap;
                    break;
            }

            // починаємо передивлятись переможні діагоналі
            for(int i = 0; i < diagonalsLenght; i++)
            {
                // обнуляємо прапор перемоги
                winFlag = 0;
                // по черзі беребираємо координати
                for(int j = 0; j < diagonalElementNumber; j++)
                {
                    // якщо на потрібних координатах ми знаходимо одиничку
                    // тоді додаємо до прапору перемоги одиничку
                    // якщо знаходимо нулик переходимо на наступну ітерацію циклу
                    if (tempMap[diagonals[i, j]] == 1)
                    {
                        winFlag++;
                        // якщо прапор перемоги набирає трійку
                        // повертаємо true що значить перемогу
                        if(winFlag == 3)
                        {
                            return true;
                        }
                    }else
                    {
                        break;
                    }
                }
            }
            return false;
        }

        // метод для запису одинички в матриці гравців
        private void addMarkInMatrix(int player, int coordinat)
        {
            // визначаємо в чию матрицю гравця чи компютера записуємо дані
            // якщо методу переданий 1 значить обчислюємо матрицю гравця
            // якщо передана двійка значить обчислюємо компютер
            switch (player)
            {
                case PLAYER_MARK:
                    playerGameMap[coordinat] = 1;
                    break;

                case COMP_MARK:
                    computerGameMap[coordinat] = 1;
                    break;
            }
            addMark(player, coordinat);
        }

        // метод для виставлення мітки на кнопку по координаті
        private void addMark(int player, int coordinat)
        {
            string symbol = "";

            switch(player)
            {
                case PLAYER_MARK:
                    symbol = "X";
                    break;
                case COMP_MARK:
                    symbol = "O";
                    break;
            }

            switch(coordinat)
            {
                case 0:
                    button1_1.Text = symbol;
                    break;
                case 1:
                    button1_2.Text = symbol;
                    break;
                case 2:
                    button1_3.Text = symbol;
                    break;
                case 3:
                    button2_1.Text = symbol;
                    break;
                case 4:
                    button2_2.Text = symbol;
                    break;
                case 5:
                    button2_3.Text = symbol;
                    break;
                case 6:
                    button3_1.Text = symbol;
                    break;
                case 7:
                    button3_2.Text = symbol;
                    break;
                case 8:
                    button3_3.Text = symbol;
                    break;
            }
        }

        // метод для визначення координати кнопки по її імені
        private int getCoordinat(string name)
        {
            switch(name)
            {
                case "button1_1":
                    return 0;
                case "button1_2":
                    return 1;
                case "button1_3":
                    return 2;

                case "button2_1":
                    return 3;
                case "button2_2":
                    return 4;
                case "button2_3":
                    return 5;

                case "button3_1":
                    return 6;
                case "button3_2":
                    return 7;
                case "button3_3":
                    return 8;

                default:
                    return 9;
            }
        }

        // метод для ходу компа
        private void compStep(int difficult)
        {
            // визначаємо складність:
            // 1 - легка -> кладемо мітку в випадковій вільній клітинці
            // 2 - середня -> заважаємо гравцю виграти
            // 3 - складна -> стараємося виграти
            switch(difficult)
            {
                case EASY_DIFFICULT_MARK:
                    easyStep();
                    break;

                case MIDDLE_DIFFICULT_MARK:
                    middleStep();
                    break;

                case HARD_DIFFICULT_MARK:
                    hardStep();
                    break;
            }
        }

        // метод для ходу в режимі легка складність
        private void easyStep()
        {
            Random rnd = new Random();
            int randomCoordinate;
            bool isMark = true;

            while (isMark)
            {
                // створюємо випадкове значення від 0 до 8
                randomCoordinate = rnd.Next(0, 8);
                // якщо клітинка порожня заповнюємо її та виходимо з циклу
                // якщо ні тоді генеруємо нову випадкову координати
                if (computerGameMap[randomCoordinate] == 0 && playerGameMap[randomCoordinate] == 0)
                {
                    addMarkInMatrix(2, randomCoordinate);
                    isMark = false;
                }
            }
        }

        // метод для ходу в режимі середня складність
        private void middleStep()
        {
            int diagonalSumm = 0;

            // починаємо передивлятись переможні діагоналі
            for (int i = 0; i < diagonalsLenght; i++)
            {
                // обнуляємо суму балів на діагоналі
                diagonalSumm = 0;
                // по черзі беребираємо координати
                for (int j = 0; j < diagonalElementNumber; j++)
                {
                    // якщо на потрібних координатах ми знаходимо одиничку
                    // тоді додаємо до суми балів діагоналі одиничку
                    if (playerGameMap[diagonals[i, j]] == 1)
                    {
                        diagonalSumm++;
                        // якщо сума балів на діагоналі = 2
                        // кладемо на вільній клітинці нулик
                        if (diagonalSumm == 2)
                        {
                            for (int s = 0; s < diagonalElementNumber; s++)
                            {
                                if (playerGameMap[diagonals[i, s]] == 0 && computerGameMap[diagonals[i, s]] == 0)
                                {
                                    addMarkInMatrix(COMP_MARK, diagonals[i, s]);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            easyStep();
            return;
        }

        // метод для ходу в режимі важка складність
        private void hardStep()
        {
            int diagonalSumm = 0;

            // починаємо передивлятись переможні діагоналі
            for (int i = 0; i < diagonalsLenght; i++)
            {
                // обнуляємо суму балів на діагоналі
                diagonalSumm = 0;
                // по черзі беребираємо координати
                for (int j = 0; j < diagonalElementNumber; j++)
                {
                    // якщо на потрібних координатах ми знаходимо одиничку
                    // тоді додаємо до суми балів діагоналі одиничку
                    if (computerGameMap[diagonals[i, j]] == 1)
                    {
                        diagonalSumm++;
                        // якщо сума балів на діагоналі = 2
                        // кладемо на вільній клітинці нулик
                        if (diagonalSumm == 2)
                        {
                            for (int s = 0; s < diagonalElementNumber; s++)
                            {
                                if (playerGameMap[diagonals[i, s]] == 0 && computerGameMap[diagonals[i, s]] == 0)
                                {
                                    addMarkInMatrix(COMP_MARK, diagonals[i, s]);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            middleStep();
            return;
        }
    }
}
