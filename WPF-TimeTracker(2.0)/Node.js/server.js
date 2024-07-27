const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const cors = require('cors');

const app = experss();
const port = 3000;

// Middleware
app.use(bodyParser.json());
app.use(cors());

// MongoDB connection
mongoose.connect('mongodb://localhost:27017/timetracker', {
    useNewUrlParser: true,
    useUnifliedTopology:true
});

const Category = mongoose.model('Category', categorySchema);

// Routes 
app.get('/api/categories', async (req, res) => {
    const category = await Category.find();
    res.json(categorues);
});

app.post('/api/categories', async (req, res) => {
    const category = new Category(req.body);
    await category.save();
    res.json(category);
});

app.delete('/api/categories/:id', async (req, res) => {
    await Category.findByIdAndDelete(req.params.id);
    res.json({ message: 'Category deleted' });
});

app.listen(port, () => {
    console.log('Server running on port ${port}');
});

