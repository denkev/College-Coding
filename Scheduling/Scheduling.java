import java.util.*;

class Process {
    int processId;
    int arrivalTime;
    int burstTime;
    int completionTime;
    int waitingTime;
    int turnAroundTime;

    public Process(int processId, int arrivalTime, int burstTime) {
        this.processId = processId;
        this.arrivalTime = arrivalTime;
        this.burstTime = burstTime;
    }
}

public class NonPreemptiveScheduling {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter number of processes: ");
        int n = sc.nextInt();

        Process[] processes = new Process[n];

        for (int i = 0; i < n; i++) {
            System.out.print("Enter arrival time for Process " + (i + 1) + ": ");
            int arrivalTime = sc.nextInt();
            System.out.print("Enter burst time for Process " + (i + 1) + ": ");
            int burstTime = sc.nextInt();
            processes[i] = new Process(i + 1, arrivalTime, burstTime);
        }

        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                if (processes[i].arrivalTime > processes[j].arrivalTime) {
                    Process temp = processes[i];
                    processes[i] = processes[j];
                    processes[j] = temp;
                }
            }
        }

        int currentTime = 0;
        for (int i = 0; i < n; i++) {
            Process proc = processes[i];

            if (proc.arrivalTime > currentTime) {
                currentTime = proc.arrivalTime;
            }

            proc.completionTime = currentTime + proc.burstTime;

            proc.turnAroundTime = proc.completionTime - proc.arrivalTime;

            proc.waitingTime = proc.turnAroundTime - proc.burstTime;

            currentTime = proc.completionTime;
        }

        System.out.println("\nProcessID\tArrivalTime\tBurstTime\tCompletionTime\tTurnaroundTime\tWaitingTime");
        for (int i = 0; i < n; i++) {
            Process proc = processes[i];
            System.out.println(proc.processId + "\t\t" + proc.arrivalTime + "\t\t" + proc.burstTime + "\t\t"
                    + proc.completionTime + "\t\t" + proc.turnAroundTime + "\t\t" + proc.waitingTime);
        }

        int totalWaitingTime = 0, totalTurnaroundTime = 0;
        for (int i = 0; i < n; i++) {
            totalWaitingTime += processes[i].waitingTime;
            totalTurnaroundTime += processes[i].turnAroundTime;
        }

        System.out.println("\nAverage Waiting Time: " + (float) totalWaitingTime / n);
        System.out.println("Average Turnaround Time: " + (float) totalTurnaroundTime / n);
    }
}
