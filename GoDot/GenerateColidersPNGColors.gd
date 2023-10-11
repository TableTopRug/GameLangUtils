extends Node

# class member variables go here, for example:
# switch to just holding the edge of the pixels that form the sides and check the 4 surrounding pixels
# arround it to to figure out which the edge of the image is being outlined
var shapePixels;

func _ready():
    shapePixels = [];
    pass

func get_shape_pixels(Image i):
    for (var y = 0; y < i.get_height(); y++):
    	shape.append(get_shape_loc_color(i, y));
    pass;
    
func get_shape_loc_color(Image i, int y):
    for (var x = 0; x < i.get_width(); x++):
        var pixel = i.get_pixel(x, y);
        if (pixel.a != 0.0):
            shapePixels.append({'x': x, 'y': y, 'color': pixel });
    pass;

func get_color_borders():
    
