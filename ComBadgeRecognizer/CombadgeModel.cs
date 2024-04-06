using Yolov5Net.Scorer.Models.Abstract;

namespace Yolov5Net.Scorer.Models;

public record CombadgeModel() : YoloModel(
    640,
    640,
    3,

    6, /// Dimensions ( label count + 5 )

    new[] { 8, 16, 32 },

    new[]
    {
        new[] { new[] { 010, 13 }, new[] { 016, 030 }, new[] { 033, 023 } },
        new[] { new[] { 030, 61 }, new[] { 062, 045 }, new[] { 059, 119 } },
        new[] { new[] { 116, 90 }, new[] { 156, 198 }, new[] { 373, 326 } }
    },

    new[] { 80, 40, 20 },

    0.20f,
    0.25f,
    0.45f,

    new[] { "output0" }, /// Name of the output. Get this by examining your model at https://netron.app

    new() /// The labels you defined before training the model. Note: IDs start by 1 here
    {
        new(1, "combadge"),
    },

    true
);
