using MVVM_Dont_Starve_Quiz.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_Dont_Starve_Quiz.ViewModels
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Term> Terms;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private Term _currentTerm;
        public Term CurrentTerm
        {
            get => _currentTerm;
            set
            {
                _currentTerm = value;
                OnPropertyChanged(nameof(CurrentTerm));
            }
        }

        private Answer _selectedTerm;
        public Answer SelectedTerm
        {
            get => _selectedTerm;
            set
            {
                _selectedTerm = value;
                CurrentTerm = SetCurrentTem(value.Id);
                OnPropertyChanged(nameof(SelectedTerm));
            }
        }

        public ApplicationViewModel()
        {
            Terms = new ObservableCollection<Term>
            {
                new Factor { Id = 0, Question = "Данный персонаж кто?", Answers = new ObservableCollection<Answer>
                    { new Answer { Text = "Я", Id = 1 }, new Answer { Text = "Ты", Id = 2 },  new Answer { Text = "Никто", Id = 3 } } },
                new Factor { Id = 1, Question = "Что умеет?", Answers = new ObservableCollection<Answer>
                    { new Answer { Text = "Есть", Id = 4 }, new Answer { Text = "Пить", Id = 5 } } },
                new Factor { Id = 2, Question = "Что ест?", Answers = new ObservableCollection<Answer>
                    { new Answer { Text = "Пиво", Id = 6 }, new Answer { Text = "Сухарики", Id = 7 } } },
                new Factor { Id = 3, Question = "Красивый?", Answers = new ObservableCollection<Answer>
                    { new Answer { Text = "Да", Id = 8 }, new Answer { Text = "Нет", Id = 9 } } },
                new Factor { Id = 4, Question = "Тильтозавр?", Answers = new ObservableCollection<Answer>
                    { new Answer { Text = "По утрам", Id = 10 }, new Answer { Text = "С похмелья", Id = 11 } } },
                new Goal { Id = 5, Question = "Ответ" }
            };
            CurrentTerm = SetCurrentTem(0);
        }

        private Term SetCurrentTem(uint id)
        {
            foreach (Term term in Terms)
                if (term.Id == id)
                    return term;
            return null;
        }
    }
}
