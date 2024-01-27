import tkinter as tk

# Create the main window
window = tk.Tk()

# Create a new canvas widget
canvas = tk.Canvas(window, width=500, height=500)
canvas.pack()

# Function to draw the apple
def draw_apple():
    # Draw the outline of the apple
    canvas.create_oval(160, 160, 340, 340, fill="darkred")
    # Draw the outline of the apple
    canvas.create_arc(150, 150, 350, 350, start=0, extent=180, fill="red")
    canvas.create_arc(150, 150, 350, 350, start=180, extent=180, fill="red")
    # Draw the stem of the apple
    canvas.create_polygon(250, 150, 250, 100, 230, 1)
# Call the function to draw the apple
draw_apple()

# Run the main loop
window.mainloop()