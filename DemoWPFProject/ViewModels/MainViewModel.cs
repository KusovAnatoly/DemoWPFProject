using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace DemoWPFProject.ViewModels;

public partial class MainViewModel: ObservableObject
{
    [ObservableProperty]
    private string _title = null!;

    [ObservableProperty]
    private Models.Task _selectedTask = null!;

    [ObservableProperty]
    private ObservableCollection<Models.Task> _tasks;

    public MainViewModel()
    {
        Tasks = new ObservableCollection<Models.Task>();
    }

    [RelayCommand]
    private void Add()
    {
        var task = new Models.Task
        {
            Title = Title,
            DueDate = DateTime.Now,
            IsCompleted = false,
        };

        Tasks.Add(task);
    }

    [RelayCommand]
    private void Remove()
    {
        if (SelectedTask is not null)
        {
            Tasks.Remove(SelectedTask);
        }
    }

    [RelayCommand]
    private void SetCompleted()
    {
        SelectedTask.IsCompleted = true;
    }
}
