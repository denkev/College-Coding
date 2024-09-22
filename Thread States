import java.util.*;

class CustomThread1 implements Runnable {
    @Override
    public void run() {
        try {
            System.out.println(Thread.currentThread().getName() + ": Unblocked (RUNNING)");
            
            // Simulate "Blocked" state by sleeping for 10 seconds
            // 1000 is 1 second
            Thread.sleep(10000);
            
            System.out.println(Thread.currentThread().getName() + ": Finished (TERMINATED)");
        } catch (InterruptedException e) {
            System.out.println(Thread.currentThread().getName() + " was interrupted.");
        }
    }
}

class CustomThread2 implements Runnable {
    private boolean suspended = false;

    public synchronized void suspendThread() {
        this.suspended = true;
    }

    public synchronized void resumeThread() {
        this.suspended = false;
        notify(); // This notify works in conjunction with the wait() method below
        
    }

    @Override
    public void run() {
        try {
            System.out.println(Thread.currentThread().getName() + ": Unblocked (RUNNING)");
            while (true) {
                synchronized (this) {
                    while (suspended) {
                        System.out.println(Thread.currentThread().getName() + ": Blocked (SUSPENDED)");
                        wait();  // Thread waits until resumed
                    }
                }
                // Simulate work
                System.out.println(Thread.currentThread().getName() + ": Working...");
                Thread.sleep(1000); // Simulate waiting for input every second
            }
        } catch (InterruptedException e) {
            System.out.println(Thread.currentThread().getName() + " was interrupted.");
        }
    }
}

public class ThreadStateDemo {
    public static void main(String[] args) throws InterruptedException {
        Scanner sc = new Scanner(System.in);

        // Choosing between two threads
        System.out.println("Enter a number (1 or 2) to choose the thread behavior:");
        int usrChoice = sc.nextInt();

        if (usrChoice == 1) {
            // Thread 1: Sleeps for 5 seconds
            Thread thread1 = new Thread(new CustomThread1(), "SleepingThread");
            System.out.println("SleepingThread: Spawn (NEW)");
            
            thread1.start();
            // The thread does not enter the Blocked (suspended) state
            // as it continues to the Unblocked (running) state because it was
            // never suspended in the first place.
            
            thread1.join();  // Wait for thread to finish
            System.out.println("SleepingThread: Finished (TERMINATED)");

        } else if (usrChoice == 2) {
            // Thread 2: Asks for input (suspend or terminate)
            CustomThread2 task2 = new CustomThread2();
            Thread thread2 = new Thread(task2, "InputThread");
            System.out.println("InputThread: Spawn (NEW)");

            thread2.start();

            // We ask for user input to suspend, resume, or terminate
            // Pressing resume even though it's running will still
            // Continue the code.
            
            while (true) {
                System.out.println("Enter 's' to suspend the thread, 'r' to resume, or 't' to terminate:");
                char action = sc.next().charAt(0);

                if (action == 's') {
                    task2.suspendThread();
                    
                } else if (action == 'r') {
                    
                    task2.resumeThread();
                    System.out.println("Unblocked (RUNNING)");
                    
                } else if (action == 't') {
                    thread2.interrupt();  // Interrupt the thread to finish it
                    System.out.println("InputThread: Finished (TERMINATED)");
                    break;
                }
            }
        } else {
            System.out.println("Invalid choice. Exiting.");
        }

    }
}
