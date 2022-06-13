using ExamSecondTry.Controller.Factories.Interfaces;
using ExamSecondTry.Controller.Handlers;
using ExamSecondTry.Data.DAL.Interfaces;
using ExamSecondTry.Data.Entities;
using ExamSecondTry.View.DisplayManager.Interfaces;
using ExamSecondTry.View.InputManager.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTryTests
{
    [TestFixture]
    public class MovieHandlerTests
    {
        [Theory]
        [TestCase()]
        public void DisplayTheLongestMovie_ForNullMovieList_ThrowsEmptyMovieListException()
        {
            //Mock<IBaseRepository<Movie>> movieRepositoryMock = new();
            //Mock<IDisplay<Movie>> movieDisplayMock = new();
            //Mock<IBaseFactory<Movie>> movieFactoryMock = new();
            //Mock<IInputSystem> inputSytemMock = new();

            //Mock<MovieHandler> movieHandler = new(movieRepositoryMock.Object, movieDisplayMock.Object, movieFactoryMock.Object, inputSytemMock.Object);
            //movieHandler.Setup(m => m.)

            //movieHandler.DisplayTheLongestMovie();
        }

    }
}
