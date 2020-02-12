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

            static float Partial1Result;
            static float Partial2Result;
            static float semesterResult;

            //Lower Limit (Minimum) points needed to get the right for final evaluation
            static float semesterResultThreshold = 12f;

        static float PartialEvaluation(float workInClass, float practice, float participation, float project) {

            float partialResult = workInClass * partialEvaluationWorkInClass
            + practice * partialEvaluationPractice
            + participation * partialEvaluationParticipation
            + project * partialEvaluationProject;

            return partialResult;
        }

        static float SemesterEvaluation(float workInClass, float practice, float participation, float project) {

            float semesterResult = workInClass * semesterEvaluationWorkInClass
            + practice * semesterEvaluationPractice
            + participation * semesterEvaluationParticipation
            + project * semesterEvaluationProject;

            return semesterResult;
        }

        static void Main(string[] args)
        {

            float partial1Result;
            float partial2Result;
            float semesterResult;

/*             partial1Result = 10 * partialEvaluationWorkInClass
            + 10 * partialEvaluationPractice
            + 10 * partialEvaluationParticipation
            + 10 * partialEvaluationProject; */

            partial1Result = PartialEvaluation(10f, 10f, 10f, 10f);

            Console.WriteLine("1st Partial Result = " + partial1Result);

            /*partial2Result = 10 * partialEvaluationWorkInClass
            + 10 * partialEvaluationPractice
            + 10 * partialEvaluationParticipation
            + 10 * partialEvaluationProject;*/

            partial2Result = PartialEvaluation(10f, 10f, 10f, 10f);

            Console.WriteLine("2nd Partial Result = " + partial2Result);

            /*semesterResult = 10 * semesterEvaluationWorkInClass
            + 10 * semesterEvaluationPractice
            + 10 * semesterEvaluationParticipation
            + 10 * semesterEvaluationProject;*/

            semesterResult = SemesterEvaluation(10f, 10f, 10f, 10f);

            Console.WriteLine("Semester Result = " + semesterResult);

            //if student has +12 points
            if(partial1Result + partial2Result >= semesterResultThreshold){
                semesterResult = SemesterEvaluation(10f, 10f, 10f, 10f);
            }
            //if student has less than 12 points
            else{
                semesterResult = 0f;
            }
            Console.WriteLine("Final result = " + semesterResult);


            if(semesterResult >= semesterResultThreshold){
                Console.WriteLine("Student has approved");
            }
            else{
                Console.WriteLine("Student has failed");
            }
        }
    }
}
