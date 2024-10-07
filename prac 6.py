import turtle
def draw_overlapping_squares(num_squares, size, overlap, color_list):
    turtle.speed(0)
    turtle.hideturtle()
    for i in range(num_squares):
        turtle.color(color_list[i % len(color_list)])
        turtle.begin_fill()
        for _ in range(4):  # Fixed the typo: changed '_in' to '_'
            turtle.forward(size)
            turtle.right(90)
        turtle.end_fill()
        turtle.penup()
        turtle.forward(size - overlap)
        turtle.pendown()

num_squares = 10
size = 50
overlap = 10
color_list = ["red", "black", "yellow", "pink", "cyan", "magenta", "purple", "red", "pink", "black"]
draw_overlapping_squares(num_squares, size, overlap, color_list)
turtle.done()
