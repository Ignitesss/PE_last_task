import pytest

from main import fact

def test_fact0():
    assert fact(0) == 1


def test_fact1():
    assert fact(1) == 1


def test_fact3():
    assert fact(3) == 6