using System;

namespace Operation_Decision_Loops
{
    class Program
    {
                    /*
            Paricales:
            Trabajo en clase - 25%
            Practicas - 25%
            Participacion - 10%
            Proyecto - 40%


            Semestral:
            Trabajo en clase - 15%
            Practicas - 20%
            Participacion - 50%
            Proyecto - 60%
            */

            static float partialEvaluationWorkInClass = 0.25f;
            static float partialEvaluationPractice = 0.25f;
            static float partialEvaluationParticipation = 0.1f;
            static float partialEvaluationProject = 0.4f;

            static float semesterEvaluationWorkInClass = 0.15f;
            static float semesterEvaluationPractice = 0.20f;
            static float semesterEvaluationParticipation = 0.05f;
            static float semesterEvaluationProject = 0.6f;

            static float partial1Result;
            static float partial2Result;
            static float semesterResult;

            //Lower Limit (Minimum) points needed to get the right for final evaluation
            static float semesterResultThreshold = 12f;

        static float PartialEvaluation1(float workInClass, float practice, float participation, float project) {

            float partialResult = workInClass * partialEvaluationWorkInClass
            + practice * partialEvaluationPractice
            + participation * partialEvaluationParticipation
            + project * partialEvaluationProject;

            //Console.WriteLine("partial1Result = " + partial1Result);

            return partialResult1;
        }

        static float PartialEvaluation2(float workInClass, float practice, float participation, float project) {

            float partialResult = workInClass * partialEvaluationWorkInClass
            + practice * partialEvaluationPractice
            + participation * partialEvaluationParticipation
            + project * partialEvaluationProject;

            //Console.WriteLine("partial1Result = " + partial1Result);

            return partialResult2;
        }

        static float semesterEvaluation(float workInClass, float practice, float participation, float project) {

            float semesterResult = workInClass * semesterEvaluationWorkInClass
            + practice * semesterEvaluationPractice
            + participation * semesterEvaluationParticipation
            + project * semesterEvaluationProject;

            //Console.WriteLine("semester1Result = " + semester1Result);

            return semesterResult;
        }

        static void Main(string[] args)
        {

/*             partial1Result = 10 * partialEvaluationWorkInClass
            + 10 * partialEvaluationPractice
            + 10 * partialEvaluationParticipation
            + 10 * partialEvaluationProject; */

            partial1Result = PartialEvaluation();

            Console.WriteLine("partial1Result = " + partial1Result);

            partial2Result = 10 * partialEvaluationWorkInClass
            + 10 * partialEvaluationPractice
            + 10 * partialEvaluationParticipation
            + 10 * partialEvaluationProject;

            Console.WriteLine("partial2Result = " + partial2Result);

            semesterResult = 10 * semesterEvaluationWorkInClass
            + 10 * semesterEvaluationPractice
            + 10 * semesterEvaluationParticipation
            + 10 * semesterEvaluationProject;

            Console.WriteLine("semesterResult = " + semesterResult);
        }
    }
}
